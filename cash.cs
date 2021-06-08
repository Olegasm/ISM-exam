/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int tf = 25;
    int te = 10;
    int fi = 5;
    int on = 1;
    int countCoins = 0;
    
    float floatNum = 0.0f;
    int integerNum;
    
    floatNum = float.Parse(Console.ReadLine());
    integerNum = (int)Math.Round(floatNum*100);
    
    while (integerNum - tf >= 0) 
    {
      if (integerNum == 0)
      {
          break;
      }
      integerNum = integerNum - tf;
      countCoins++;
    }
    
    while (integerNum - te >= 0) 
    {
        if (integerNum == 0)
        {
          break;
        }
      integerNum = integerNum - te;
      countCoins++;
    }
    
    while (integerNum - fi >= 0) 
    {
        if (integerNum == 0)
        {
          break;
        }
        
      integerNum = integerNum - fi;
      countCoins++;
    }
      
    while (integerNum - on >= 0) 
    {
        if (integerNum == 0)
        {
          break;
        }
        
      integerNum = integerNum - on;
      countCoins++;
    }
    
    Console.WriteLine(countCoins);
  }
}
