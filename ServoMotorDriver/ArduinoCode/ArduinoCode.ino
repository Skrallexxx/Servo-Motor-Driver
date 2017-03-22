/*
 Name:		ArduinoCode.ino
 Created:	3/7/2017 11:31:51 AM
 Author:	Alex
*/
byte DacValue = 255;
byte DecoderA = 0, DecoderB = 0;

byte checksum = 0;
byte startByte = 0, portByte = 0, dataByte = 0, checkByte = 0;
byte START = 255, REQ = 0;

const byte DecoderAPort = 0, DecoderBPort = 1, DACPort = 2, DACCheckPort = 3;

// the setup function runs once when you press reset or power the board
void setup() {
	Serial.begin(9600);
	DDRA = 0xFF;
	DDRF = 0x00;
	DDRK = 0x00;

	PORTA = (byte)197;
	PORTC = bitFlip((byte)195);
}

// the loop function runs over and over again until power down or reset
void loop() {
	if (!Serial)
		Serial.begin(9600);

	while (Serial.available() >= 4) {
		startByte = Serial.read();

		if (startByte != START) return;
		portByte = Serial.read();
		dataByte = Serial.read();
		checkByte = Serial.read();
		checksum = startByte + portByte + dataByte;

		if (checkByte != checksum) return;

		// Request for Decoder Port A data received, read the port and send data
		if (portByte == DecoderAPort) {
			DecoderA = PINF;
			SendOutgoingData(DecoderAPort, DecoderA);
		}

		// Request for Decoder Port B data received, read the port and send data
		if (portByte == DecoderBPort) {
			DecoderB = PINK;
			SendOutgoingData(DecoderBPort, DecoderB);
		}

		// DAC data received, write it to the DAC port
		if (portByte == DACPort) {
			DacValue = dataByte;
			PORTA = DacValue;
		}

		if (portByte == DACCheckPort) {
			SendOutgoingData(DACCheckPort, DacValue);
		}
	}
}

void SendOutgoingData(byte PORT, byte DATA) {
	Serial.write(START);
	Serial.write(PORT);
	Serial.write(DATA);
	Serial.write((byte)(START + PORT + DATA));
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
