using System;

class Encription
{
  static void Main()
  {
    Console.WriteLine("Enter a word to have it encrypted");
    string inputWord = Console.ReadLine();

    EncriptedWord(inputWord);
  }
  static void EncriptedWord(string recievedWord)
  {
    string replaceA = recievedWord.Replace("a", "-");
    string replaceE = replaceA.Replace("e", "-");
    string replaceI = replaceE.Replace("i", "-");
    string replaceO = replaceI.Replace("o", "-");
    string replaceU = replaceO.Replace("u", "-");
    Console.WriteLine("Your encrypted word is: " + replaceU + ".");

  }
}
