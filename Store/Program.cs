//{int i = 0;
//while (i < 10)
//{
    //Console.WriteLine("hej");
    //i++;
//}

//for (int j=0; j < 10; j++)
//{
    //Console.WriteLine("hej");
//}

 

//bool success = false;
//int ageNum = 0;

//while (success != true)
//{
    //Console.WriteLine("Ålder:");
    //string age = Console.ReadLine();

    //success = int.TryParse(age, out ageNum);

    //if (success == false)
    //{
        //Console.WriteLine("Skriv en siffra, dumhuvve");
    //}
//}
//if (ageNum >= 18)
//{
    //Console.WriteLine("Välkommen!");
//}

//Console.ReadLine();}

﻿int playerMoney = 100;

while (playerMoney > 0)
{
  Console.WriteLine($"Du har {playerMoney} kronor kvar");

  Console.WriteLine("Vad vill du köpa?");
  Console.WriteLine("1. En bronsmedalj (10kr)");
  Console.WriteLine("2. En silvermedalj (20kr)");
  Console.WriteLine("3. En guldmedalj (30kr)");

  string whatToBuy = "";
  while (whatToBuy != "1" && whatToBuy != "2" && whatToBuy != "3")
  {
    whatToBuy = Console.ReadLine();
  }

  int pricePerItem = 0;

  if (whatToBuy == "1")
  {
    pricePerItem = 10;
  }
  else if (whatToBuy == "2")
  {
    pricePerItem = 20;
  }
  else if (whatToBuy == "3")
  {
    pricePerItem = 30;
  }

  Console.WriteLine("Hur många vill du köpa?");
  int numToBuy = 0;
  while (numToBuy == 0)
  {
    string num = Console.ReadLine();
    bool success = int.TryParse(num, out numToBuy);
    if (success == false)
    {
      Console.WriteLine("Du måste skriva en siffra!");
    }
  }

  int finalCost = pricePerItem * numToBuy;

  if (finalCost <= playerMoney)
  {
    Console.WriteLine("Ja, det går bra.");
    playerMoney -= finalCost;
  }
  else
  {
    Console.WriteLine("Nej, det har du inte råd med!");
  }
}

Console.WriteLine("Nu har du slut på pengar!");
Console.WriteLine("Tryck på ENTER för att avsluta");
Console.ReadLine();