/*
 Name:		ArduinoCode.ino
 Created:	3/7/2017 11:31:51 AM
 Author:	Alex
*/

byte Output1 = 255, Output2 = 255;
byte Input1 = 0, Input2 = 0;

byte checksum = 0;
byte startByte = 0, portByte = 0, dataByte = 0, checkByte = 0;
byte START = 255, REQ = 0;

const byte Input1Port = 0, Input2Port = 1, Output1Port = 2, Output2Port = 3;

// the setup function runs once when you press reset or power the board
void setup() {
	Serial.begin(9600);
	DDRA = 0xFF;
	DDRC = 0xFF;
	DDRF = 0x00;
	DDRK = 0x00;

	PORTA = (byte)197;
	PORTC = bitFlip((byte)195);
}

// the loop function runs over and over again until power down or reset
void loop() {
	if (!Serial)
		Serial.begin(9600);

	while (Serial.available >= 4) {
		startByte = Serial.read();

		if (startByte != START) return;
		portByte = Serial.read();
		dataByte = Serial.read();
		checkByte = Serial.read();
		checksum = startByte + portByte + dataByte;

		if (checkByte != checksum) return;

		// Request for Input1 data received, read the port and send data
		if (portByte = Input1Port) {
			Input1 = PINF;
			SendOutgoingData(Input1Port, Input1);
		}

		// Request for Input2 data received, read the port and send data
		if (portByte = Input2Port) {
			Input2 = PINK;
			SendOutgoingData(Input2Port, Input2);
		}

		// Output1 data received, write it to the port
		if (portByte = Output1Port) {
			Output1 = dataByte;
			PORTA = Output1;
		}

		// Output2 data received, write it to the port
		if (portByte = Output2Port) {
			Output2 = dataByte;
			PORTC = Output2;
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
	for (byte i = 0; i < 8; i++ {
		bitWrite(bFlip, i, bitRead(value, j));
			j--;
	}
	return bFlip;
}