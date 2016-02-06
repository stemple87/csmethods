using System;

class Grades
{
  static void Main()
  {
    Console.WriteLine("What grade did you get in your last class? Enter A, B, C, D, or F");
    string grade = Console.ReadLine();
    if (grade == "A" || grade == "B") {
      Console.WriteLine("Nice job!");
    } else if (grade == "C") {
      Console.WriteLine("Try harder next time.");
    } else {
      Console.WriteLine("Bad job.");
    }
  }
}
