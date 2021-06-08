/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    //Console.WriteLine("Hello World");
    
    float valueFloat = 0.0f;
    int value;
    int coins = 0;
    
    valueFloat = float.Parse(Console.ReadLine());
    value = (int)Math.Round(valueFloat*100);
    
    Console.WriteLine(value);
    
    while (value >= 25) //how many quarters
    {
        value -= 25;
        coins++;
    }
    while (value >= 10) //how many quarters
    {
        value -= 10;
        coins++;
    }
    while (value >= 5) //how many quarters
    {
        value -= 5;
        coins++;
    }
    while (value >= 1) //how many quarters
    {
        value -= 1;
        coins++;
    }
    
    Console.WriteLine(coins);
  }
}
