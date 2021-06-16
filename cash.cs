using System;
class HelloWorld {
  static void Main() {
    string userInputString = Console.ReadLine();
    float userInputFloat = float.Parse(userInputString);
    int userInputInt = (int)Math.Round(userInputFloat * 100);
    int counter = 0;
    while(userInputInt > 0)
    {
        if(userInputInt - 25 >= 0)
        {
            userInputInt = userInputInt - 25;
            counter++;
        }
        else if (userInputInt - 10 >= 0)
        {
            userInputInt = userInputInt - 10;
            counter++;
        }
        else if (userInputInt - 5 >= 0)
        {
            userInputInt = userInputInt - 5;
            counter++;
        }
        else if (userInputInt - 1 >=0)
        {
            userInputInt = userInputInt - 1;
            counter++;
        }
    }
    
    
    Console.WriteLine(counter);
  }
}
  }
}
