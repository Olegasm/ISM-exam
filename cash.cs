/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Cash {
  static void Main(string[] args) {
    string userInput = Console.ReadLine();
    float d;
    int coins = 0;
    
     do
     {
         d = float.Parse(userInput);
     }
     while (d <= 0);
      
    // convert to integer
    int cts = (int)Math.Round(d * 100);
      
      
     
    while (cts >= 25) // check quarters first, then lesser coins
    {
        coins ++;
        cts -= 25;
    }

    while (cts >= 10)
    {
        coins ++;
        cts -= 10;
    }

    while (cts >= 5)
    {
        coins ++;
        cts -= 5;
    }

    while (cts >= 1)
    {
        coins ++;
        cts -= 1;
    }
    
    Console.WriteLine("I have that many coins = {0}", coins);
}
}
