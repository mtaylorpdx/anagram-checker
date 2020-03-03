using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("What is the password");
      string initialWord = Console.ReadLine();
      Console.WriteLine("Enter a list of words");
      string comparisonWords = Console.ReadLine();
      Ana newWord = new Ana(initialWord, comparisonWords);
      newWord.AnaList();
      List<string> output = newWord.GetOutput();
      foreach (string outputWord in output)
      {
        Console.WriteLine(outputWord);
      }
    }
  }
}