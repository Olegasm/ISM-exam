using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter sum of money");
    float floatNumber = 0.0f;
    int intNumber;      
        // use of Single.Parse() Method
        floatNumber = float.Parse(Console.ReadLine());
    intNumber = (int)Math.Round(floatNumber*100);
    
    int i = intNumber;
    int counter = 0;
    while (i >= 25) 
    {
      i = i - 25;
      counter++;
    }
    
    while (i >= 10) 
    {
      i = i - 10;
      counter++;
    }
    
    while (i >= 5) 
    {
      i = i - 5;
      counter++;
    }
    
    while (i == 1) 
    {
      counter++;
      i = i - 1;
    }

    Console.WriteLine(counter);
  }
}
