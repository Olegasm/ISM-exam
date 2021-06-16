using System;
class HelloWorld
{
  static void Main ()
  {
    Console.WriteLine ("Change:");
    string Schange = Console.ReadLine ();
    float fchange = float.Parse (Schange);
    int change = (int) Math.Round (fchange * 100);
    int coins = 0;
    while (change > 0)
    {
	if (change - 25 >= 0)
	  {
	    coins++;
	    change -= 25;
	  }
	else if (change - 10 >= 0)
	  {
	    coins++;
	    change -= 10;
	  }
	else if (change - 5 >= 0)
	  {
	    coins++;
	    change -= 5;
	  }
	else if (change - 1 >= 0)
	  {
	    coins++;
	    change -= 1;
	  }
    }
    Console.WriteLine (coins);
  }
}
