/*
 Name:		ArduinoCode.ino
 Created:	3/7/2017 11:31:51 AM
 Author:	Alex
*/
// Decoder Pin Mappings
const int SEL = PORTK0, OE = PORTK1, RST = PORTK2;

// Output & Input Variables
byte dacValue = 255;
byte decoderHigh = 0, decoderLow = 0;

// Communication Variables
byte checksum = 0;
byte startByte = 0, portByte = 0, dataByte = 0, checkByte = 0;
const byte START = 255, REQ = 0;
const byte DecoderHighPort = 0, DecoderLowPort = 1, DACPort = 2, DACCheckPort = 3;

// Decoder Polling Variables
int deltaT = 100; // Time period to read in microseconds
int64_t oldMicros = 0;
int16_t tempData = 0;

// the setup function runs once when you press reset or power the board
void setup() {
	Serial.begin(9600);
	DDRA = 0xFF;
	DDRF = 0x00;
	DDRK = 0x00;
}

// the loop function runs over and over again until power down or reset
void loop() {
	if (!Serial)
    Serial.begin(9600);
  if(tempData >= 20000) tempData = 0;

	if (checkTime(deltaT)) {
		ReadDecoderBytes();
    tempData++;
	}

	while (Serial.available() >= 4) {
		startByte = Serial.read();

		if (startByte != START) return;
		portByte = Serial.read();
		dataByte = Serial.read();
		checkByte = Serial.read();
		checksum = startByte + portByte + dataByte;

		if (checkByte != checksum) return;

		// Request for Decoder Port A data received, read the port and send data
		if (portByte == DecoderHighPort) {
			//SendOutgoingData(DecoderHighPort, decoderHigh);
			SendOutgoingData(DecoderHighPort, (byte)(tempData >> 8));
		}

		// Request for Decoder Port B data received, read the port and send data
		if (portByte == DecoderLowPort) {
			//SendOutgoingData(DecoderLowPort, decoderLow);
			SendOutgoingData(DecoderLowPort, (byte)(tempData));
		}

		// DAC data received, write it to the DAC port
		if (portByte == DACPort) {
			dacValue = dataByte;
			PORTA = dacValue;
		}

		if (portByte == DACCheckPort) {
			SendOutgoingData(DACCheckPort, dacValue);
		}
	}
}

void SendOutgoingData(byte PORT, byte DATA) {
	Serial.write(START);
	Serial.write(PORT);
	Serial.write(DATA);
	Serial.write((byte)(START + PORT + DATA));
}

bool checkTime(int32_t timeChange) {
	if (micros() - oldMicros >= timeChange) {
		oldMicros = micros();
		return true;
	}
	return false;
}

void ReadDecoderBytes() {
	digitalWrite(SEL, LOW);
	digitalWrite(OE, LOW);

	decoderHigh = PINF;
	
	digitalWrite(SEL, HIGH);

	decoderLow = PINF;

	digitalWrite(OE, HIGH);
}

byte bitFlip(byte value) {
	byte bFlip = 0;
	byte j = 7;
	for (byte i = 0; i < 8; i++) {
		bitWrite(bFlip, i, bitRead(value, j));
			j--;
	}
	return bFlip;
}
