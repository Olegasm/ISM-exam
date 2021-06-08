using System;
class HelloWorld {
  static void Main(string[] args) {
    string userInput = Console.ReadLine();
    float number;
    int counter = 0;
    
      // convert to integer
      number = float.Parse(userInput);

    int intNum = (int)Math.Round(number * 100);
      // display the line
    //Console.WriteLine(intNum);
    
    while (intNum > 0) 
    {
        if (intNum >= 25)
        {
            intNum = intNum - 25;
            counter++;
        }
        else if (intNum >= 10)
        {
            intNum = intNum - 10;
            counter++;
        }
        else if (intNum >= 5)
        {
            intNum = intNum - 5;
            counter++;
        }
        else if (intNum >= 1)
        {
            intNum = intNum - 1;
            counter++;
        }
    }
    
    Console.WriteLine("Input = {0}", counter);
  }
}
