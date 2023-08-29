/*  This Code Modified By MEG
 *   Main RFID Code belong to ROBOTİSTAN
 *   
 *   Modifying date : 03 / 12 / 2021
 *   
 *   -- I hope we will complate this project by deadline -- MEG
 */



#include <MFRC522.h>
#include <SPI.h>



//SCK 13
//MISO 12
//MOSI 11
//SDA 10
// RESET 9

int reset = 9;
int ss = 10;

MFRC522 rfid(ss,reset);

byte ID[4] ={43,234,104,41}; // MEG
byte ID2[4] ={214,168,35,163}; // MUTLU
byte ID3[4] = {225,70,7,0}; //ECEM
byte ID4[4] = {27,114,184,27}; //BERKAY
byte IDAdmin[4] = {250,68,100,73};  //ADMIN MEG



void setup() {
  

  

  Serial.begin(9600);
  Serial.println("deneme");
  Serial.println("deneme2");
  Serial.println("deneme3");
  
  
  SPI.begin();
  rfid.PCD_Init();


  pinMode(7,OUTPUT);   // MEG         PB1
  pinMode(6,OUTPUT);   // MUTLU       PB15
  pinMode(5,OUTPUT);   // BERKAY      PB14
  pinMode(4,OUTPUT);   //ECEM         PB13  
  
  digitalWrite(7,LOW);
  digitalWrite(6,LOW);
  digitalWrite(5,LOW);
  digitalWrite(4,LOW);
}

void loop() {
  // put your main code here, to run repeatedly:

    if (!rfid.PICC_IsNewCardPresent())
    return;

    if(! rfid.PICC_ReadCardSerial())
    return;

    if(rfid.uid.uidByte[0] == ID[0] &&
      rfid.uid.uidByte[1] == ID[1] &&
      rfid.uid.uidByte[2] == ID[2] && 
      rfid.uid.uidByte[3] == ID[3]  ){

   //     ekranaYazdir();
        Serial.println("MEG");
        digitalWrite(7,HIGH);
        delay(500);
        digitalWrite(7,LOW);
        
      }

      else if (rfid.uid.uidByte[0] == ID2[0] &&
      rfid.uid.uidByte[1] == ID2[1] &&
      rfid.uid.uidByte[2] == ID2[2] && 
      rfid.uid.uidByte[3] == ID2[3]  ){

       // ekranaYazdir();
        Serial.println("MUTLU");
        digitalWrite(6,HIGH);
        delay(500);
        digitalWrite(6,LOW);
        
      }

//      else if (rfid.uid.uidByte[0] == ID3[0] &&
//      rfid.uid.uidByte[1] == ID3[1] &&
//      rfid.uid.uidByte[2] == ID3[2] && 
//      rfid.uid.uidByte[3] == ID3[3]  ){
//
//        //ekranaYazdir();
//        //Serial.println("ECEM");
//        digitalWrite(4,HIGH);
//        delay(500);
//        digitalWrite(4,LOW);
        
//      }

      else if (rfid.uid.uidByte[0] == ID4[0] &&
      rfid.uid.uidByte[1] == ID4[1] &&
      rfid.uid.uidByte[2] == ID4[2] && 
      rfid.uid.uidByte[3] == ID4[3]  ){

        //ekranaYazdir();
        Serial.println("BERKAY");
        digitalWrite(5,HIGH);
        delay(500);
        digitalWrite(5,LOW);
      }

      else if (rfid.uid.uidByte[0] == IDAdmin[0] &&
      rfid.uid.uidByte[1] == IDAdmin[1] &&
      rfid.uid.uidByte[2] == IDAdmin[2] && 
      rfid.uid.uidByte[3] == IDAdmin[3]  ){

        //ekranaYazdir();
       // Serial.println("ECEM");
        digitalWrite(4,HIGH);
        delay(500);
        digitalWrite(4,LOW);
        
      }
    
    else {
      //Serial.println("yetkisiz kart");
      //ekranaYazdir();
      }
      
}

void ekranaYazdir(){

  //Serial.print("ID NO : ");
  for (int sayac= 0 ; sayac<4 ;sayac++){
    //Serial.print(rfid.uid.uidByte[sayac]);
    //Serial.print(" " );
    
    
  } delay(100);
  
}
