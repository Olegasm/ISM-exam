using System;
class HelloWorld {
  static void Main() {
      
    float floatNumber = 0.0f;
    int intNumber;
    int coinsUsed = 0;
    
    do {
   floatNumber = float.Parse(Console.ReadLine());

   if (floatNumber < 0 && ) {
       
     Console.WriteLine("Number cannot be negative");
    }
    }while(floatNumber < 0);
    
    intNumber = (int)Math.Round(floatNumber*100);
  
  while(intNumber >= 25)
  {
      intNumber = intNumber - 25;
      coinsUsed = coinsUsed + 1;
  }
  while(intNumber >= 10)
  {
      intNumber = intNumber - 10;
      coinsUsed = coinsUsed + 1;
  }
  while(intNumber >= 5)
  {
      intNumber = intNumber - 5;
      coinsUsed = coinsUsed + 1;
  }
  while(intNumber >= 1)
  {
      intNumber = intNumber - 1;
      coinsUsed = coinsUsed + 1;
  }
  
  Console.WriteLine(coinsUsed);
      
  }
}
