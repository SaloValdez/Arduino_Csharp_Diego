
#include <DHT.h> 
#include <Servo.h>

Servo microservo; 
int pos = 0; //SERVO---------//posicion INICIAL del servo



//sensor de led
const int pinLED = 22;
const int pinAUDIO = 34;



const int ledAlterna = 20; //FOCO ALTERNA
int num;  //EJEMPLO PARA MOSTRAR TEMPERATURA CON PRINTLN


//sensor de temperatura
//int SENSOR  =2;
//int temp, humedad;
//DHT dht(SENSOR,DHT11);



void setup()
{
   Serial.begin(9600);
   pinMode(pinLED, OUTPUT);
   pinMode(pinAUDIO, OUTPUT);
   pinMode(ledAlterna,OUTPUT);

    //inicializar el sensor
   dht.begin();

   
  //inicializar servo
  microservo.attach(50);  // Se configura como Servo el Puerto 11----------------------------------------------------------------

  num =0;
 
}
 
void loop() {
//
//    humedad  = dht.readHumidity(); //coger la humedad y guardar en la variable temp
//    temp = dht.readTemperature();//coger la temperatura y guardar en la variable temp
    
//    Serial.print("Temperatura:");
//    Serial.print(temp);
//    Serial.print("°C  Humedad : ");
//    Serial.print(humedad);
//    Serial.println("%");
//    delay(500);
num = num+1;
Serial.println(num);
delay(500);
  

  
   if (Serial.available() > 0)
   {
      int option = Serial.read();
      if (option == 'a')
      {
         digitalWrite(pinLED, LOW);  
         digitalWrite(pinAUDIO, LOW);    
      }
      if (option == 'b')
      {
         digitalWrite(pinLED, HIGH);
         digitalWrite(pinAUDIO, HIGH);   
      }


         if (option == '0')
      {
         digitalWrite(ledAlterna, HIGH);
          
      }

          if (option == '1')
      {
         digitalWrite(ledAlterna, LOW);
          
      }
      


      //SERVOMOTORES
     if(option=='j'){for(pos = 180; pos>=1; pos-=3)     //Giro de 180 a 0 grados 
                      {microservo.write(pos);delay(15);} }
     if(option=='i'){for(pos = 0; pos < 180; pos += 3)  // Giro de 0 a 180 grados 
                      {microservo.write(pos);delay(15);}}  // Espera 15 ms para que el servo llege a la posicion

      
   }
}
