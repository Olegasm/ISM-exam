using System;
class HelloWorld {
  static void Main() {
    
    float floatNumber = 0.0f;
    int intNumber;      
        // use of Single.Parse() Method
    Console.WriteLine("Enter a number: ");
    floatNumber = float.Parse(Console.ReadLine());
    intNumber = (int)Math.Round(floatNumber*100);
    
    
    int coins = 0;
    
    
    while (intNumber >= 25) 
    {
      coins++; 
      intNumber = intNumber - 25;
    ;
    }
    while (intNumber >= 10) 
    {
      coins++; 
      intNumber = intNumber -10;
    ;
    }
    while (intNumber >= 5) 
    {
      coins++; 
      intNumber = intNumber - 5;
    ;
    }
    while (intNumber >= 1) 
    {
      coins++; 
      intNumber = intNumber - 1;
    ;
    }
    Console.WriteLine("Number of coins required: ");
    Console.WriteLine(coins);
  }
}
