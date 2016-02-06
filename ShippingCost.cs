using System;

class ShippingCost
{
  static void Main()
  {

    Console.WriteLine("Enter your packages weight");
    string weightInput = Console.ReadLine();
    Console.WriteLine("Enter the distance your package will travel");
    string travelInput = Console.ReadLine();
    ShippingCalculation(weightInput, travelInput);
  }
  static void ShippingCalculation(string packageWeight, string distanceToTravel)
  {
    int weightNumber = int.Parse(packageWeight);
    int travelNumber = int.Parse(distanceToTravel);
    int totalCost = (weightNumber / 10) + (travelNumber / 5) * 2;
    string totalCostString = totalCost.ToString();
    Console.WriteLine("Your totalCost will be: $" + totalCostString + ".");
  }
}
