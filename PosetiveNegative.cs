using System;

class PositiveNegative
{
  static void Main()
  {
    Console.WriteLine("Enter a number. If it is a positive number 1 will be added. If it is negative, 1 will be subtracted.");
    string userInput = Console.ReadLine();
    int userNumber = int.Parse(userInput);
    if (userNumber > 0)
    {
      userNumber++;
    }
    else
    {
      userNumber--;
    }
    string numberString = userNumber.ToString();
    Console.WriteLine("Your new number is : " + numberString + ".");
  }
}
