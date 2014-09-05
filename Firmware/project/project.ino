
// right hand
int rightRing = 12;
int rightMiddle = 8;
int rightIndex = 10;

// left hand
int leftIndex = 5;
int leftMiddle = 3;
int leftRing = 7;

void setup() {
  // open the serial port:
  Serial.begin(9600);

  // initialize the digital pins as outputs.
  pinMode(rightRing, OUTPUT);
  pinMode(rightMiddle, OUTPUT);
  pinMode(rightIndex, OUTPUT);  
  pinMode(leftRing, OUTPUT);
  pinMode(leftMiddle, OUTPUT);
  pinMode(leftIndex, OUTPUT);
}

void loop() {
  
  // 0 - left ring; 1 - left middle; 2 - left index; 3 - right index; 4 - right middle; 5 - right ring
  char message[24];
  
  // wait for input
  while (!Serial.available());
   // read message
  Serial.readBytesUntil('\n', message, 24);
  Serial.println(message);
  
  // decode message
  int numLeftIndex = 0;
  int numLeftMiddle = 0;
  int numLeftRing = 0;
  int numRightIndex = 0;
  int numRightMiddle = 0;
  int numRightRing = 0;
  sscanf(message, "%d;%d;%d;%d;%d;%d;", &numLeftIndex, &numLeftMiddle, &numLeftRing, &numRightIndex, &numRightMiddle, &numRightRing);
//  Serial.println(numLeftIndex + ' ' + numLeftMiddle + ' ' + numLeftRing + ' ' + numRightIndex + ' ' + numRightMiddle + ' ' + numRightRing);
  
  analogWrite(leftIndex, numLeftIndex);
  analogWrite(leftMiddle, numLeftMiddle);
  analogWrite(leftRing, numLeftRing);
  analogWrite(rightIndex, numRightIndex);
  analogWrite(rightMiddle, numRightMiddle);
  analogWrite(rightRing, numRightRing);
}
