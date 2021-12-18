using System;

// {
//   static void Main()
//   {
//     Console.WriteLine("How old are you?");
//     string stringUserAge = Console.ReadLine();
//     int intUserAge = int.Parse(stringUserAge);

//     if (intUserAge >= 17)
//     {
//       Console.WriteLine("You can see the movie!");
//     }
//     else
//     {
//       Console.WriteLine("I'm sorry, you are too young to see the movie.");
//     }
//   }
// }    

class FirstLetterChecker
{
  static void Main()
  {
    Console.WriteLine("What is your name?");
    string inputName = Console.ReadLine();
    string userName = inputName.ToUpper();
    if (userName.StartsWith("Z"))
    {
      Console.WriteLine("Your name starts with a Z!");
    }
    else
    {
      Console.WriteLine("Your name doesn't start with a Z :(");
    }
  }
}