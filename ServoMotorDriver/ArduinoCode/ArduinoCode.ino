/*
Name:		ArduinoCode.ino
Created:	3/7/2017 11:31:51 AM
Author:	Alex
*/
// Decoder Pin Mappings
const int SEL = 37, OE = 36, RST = 35;

// Output & Input Variables
byte dacValue = 137;
byte decoderHigh = 0, decoderLow = 0;

// Communication constants
const byte START = 0x7E, PAD = 0x7D, END = 0x7E;

// Communication command constants
const byte cmdReadDecoder = 0x01, cmdRstDecoder = 0x02, cmdSetDAC = 0x03, cmdReadDAC = 0x04;

// Communication storage variables
byte cmdByte = 0; // The received communication command (see command constants above)
byte lenByte1 = 0, lenByte2 = 0; // Received length of the communication frame
byte checkByte1 = 0, checkByte2 = 0; // The received check bytes

// Decoder Polling Variables
int deltaT = 1000; // Time period to read in microseconds
int64_t oldMicros = 0;
int64_t oldMillis = 0;
int32_t dataValue = 0;

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
  
	if (checkTime(deltaT)) {
		//ReadDecoderBytes();
		dataValue += 10;
	}
	
	while (Serial.available() >= 8) {
		int16_t checkSum = 0;
		if (Serial.read() != START) return;
		cmdByte = Serial.read();
		lenByte1 = Serial.read();

		byte* dataBytes = new byte[lenByte1];

		for (int i = 0; i < lenByte1; i++) {
			dataBytes[i] = Serial.read();
			checkSum += dataBytes[i];
		}

		lenByte2 = Serial.read();
		checkByte1 = Serial.read();
		checkByte2 = Serial.read();
		if (Serial.read() != END) return;
		if (lenByte1 != lenByte2) return;

		checkSum += cmdByte + lenByte1 + lenByte2;
		int16_t receivedCheckSum = (int16_t)((checkByte1 << 8) | checkByte2);
		if (checkSum != receivedCheckSum) return;

    if(cmdByte == cmdReadDecoder) {
        unsigned long timeStamp = 0;
        timeStamp = ReadDecoderBytes();
        byte bytes[] = { (byte)(timeStamp >> 24), (byte)(timeStamp >> 16), (byte)(timeStamp >> 8), (byte)(timeStamp), (byte)(dataValue >> 8), (byte)(dataValue) };
        SendOutgoingData(cmdReadDecoder, 6, bytes);
    }
    else if(cmdByte == cmdRstDecoder) {
        dataValue = 0;
        digitalWrite(RST, LOW);
        delay(2);
        digitalWrite(RST, HIGH);
        byte bytes[] = {100};
    }
    else if (cmdByte == cmdSetDAC) {
        dacValue = dataBytes[0];
        PORTA = dacValue;
    }
    else if (cmdByte == cmdReadDAC) {
        byte bytes[] = { dacValue };
        SendOutgoingData(cmdReadDAC, 1, bytes);
    }

    delete(dataBytes);
	}
}

void SendOutgoingData(byte CMD, byte LEN, byte DATA[]) {
  byte* bytesToWrite = new byte[7 + LEN];
  bytesToWrite[0] = START; bytesToWrite[1] = CMD; bytesToWrite[2] = LEN;
  
	int16_t checkSum = 0;

	for (int i = 0; i < LEN; i++) {
		//Serial.write(DATA[i]);
    bytesToWrite[3 + i] = DATA[i];
		checkSum += DATA[i];
	}

	checkSum += CMD + LEN + LEN;
  bytesToWrite[3 + LEN] = LEN; bytesToWrite[4 + LEN] = (byte)(checkSum >> 8); bytesToWrite[5 + LEN] = (byte)checkSum; bytesToWrite[6 + LEN] = END;
  Serial.write(bytesToWrite, 7 + LEN);
  delete(bytesToWrite);
}

bool checkTime(int32_t timeChange) {
	if (micros() - oldMicros >= timeChange) {
		oldMicros = micros();
		return true;
	}
	return false;
}

unsigned long ReadDecoderBytes() {
  int64_t timeDiff = millis() - oldMillis;
  oldMillis = millis();
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
	return (int32_t)timeDiff;
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
