/*
Name:		ArduinoCode.ino
Created:	3/7/2017 11:31:51 AM
Author:	Alex
*/
// Decoder Pin Mappings
const int SEL = 37, OE = 36, RST = 35;

// Output & Input Variables
byte dacValue = 255;
byte decoderHigh = 0, decoderLow = 0;

// Communication Variables
byte checksum = 0;
byte startByte = 0, portByte = 0, dataByte = 0, checkByte = 0;
const byte START = 255, REQ = 0;
const byte DecoderHighPort = 0, DecoderLowPort = 1, DACPort = 2, DACCheckPort = 3, DecoderRSTPort = 4;

// Decoder Polling Variables
int deltaT = 1000; // Time period to read in microseconds
int64_t oldMicros = 0;
int32_t tempData = 0;

// the setup function runs once when you press reset or power the board
void setup() {
	Serial.begin(115200);
	DDRA = 0xFF;
	DDRC = 0xFF;
	DDRK = 0x00;
  digitalWrite(RST, HIGH);
}

// the loop function runs over and over again until power down or reset
void loop() {
	if (!Serial)
		Serial.begin(115200);
  /*
	if (checkTime(deltaT)) {
		ReadDecoderBytes();
		//tempData += 1;
	}

  tempData = (int32_t)((int16_t)((bitFlip(decoderHigh) << 8) | bitFlip(decoderLow)));

	if (tempData >= 20000 || tempData <= -20000) {
		if (tempData >= 20000)
			SendOutgoingData(DecoderRSTPort, (byte)1);
		else if (tempData <= -20000)
			SendOutgoingData(DecoderRSTPort, (byte)2);
		tempData = 0;
    digitalWrite(RST, LOW);
    delay(2);
    digitalWrite(RST, HIGH);
	}
  */
  
	while (Serial.available() >= 4) {
		startByte = Serial.read();

		if (startByte != START) return;
		portByte = Serial.read();
		dataByte = Serial.read();
		checkByte = Serial.read();
		checksum = startByte + portByte + dataByte;

		if (checkByte != checksum) return;

		// Request for Decoder Port A data received, read the port and send data
    if(portByte == DecoderHighPort || portByte == DecoderLowPort) {
      ReadDecoderBytes();
    }
    
		if (portByte == DecoderHighPort) {
			SendOutgoingData(DecoderHighPort, bitFlip(decoderHigh));
			//SendOutgoingData(DecoderHighPort, (byte)(tempData >> 8));
		}

		// Request for Decoder Port B data received, read the port and send data
		if (portByte == DecoderLowPort) {
			SendOutgoingData(DecoderLowPort, bitFlip(decoderLow));
			//SendOutgoingData(DecoderLowPort, (byte)(tempData));
		}

		// DAC data received, write it to the DAC port
		if (portByte == DACPort) {
			dacValue = dataByte;
			PORTA = dacValue;
		}

		if (portByte == DACCheckPort) {
			SendOutgoingData(DACCheckPort, dacValue);
		}

    if(portByte == DecoderRSTPort) {
      digitalWrite(RST, LOW);
      delay(2);
      digitalWrite(RST, HIGH);
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
  delay(2);
	decoderHigh = PINF;
  delay(2);
	digitalWrite(SEL, HIGH);
  delay(2);
	decoderLow = PINF;
  delay(2);
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
