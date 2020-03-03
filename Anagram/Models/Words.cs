using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Models
{
  public class Ana
  {
    public string InitialWord {get;set;}
    public string[] ComparisonWords {get;set;} = {};
    public static List<string> FinalOutput {get;} = new List<string> {};
    public Ana(string input, string forArray)
    {
      InitialWord = input;
      ComparisonWords = forArray.Split(' ');
    }
    public static void ClearAll()
    {
      FinalOutput.Clear();
    }
    public bool AnaSorter(string wordOne, string wordTwo)
    {
      char[] charsOne = wordOne.ToLower().ToCharArray();
      Array.Sort(charsOne);
      char[] charsTwo = wordTwo.ToLower().ToCharArray();
      Array.Sort(charsTwo);
      return charsOne.SequenceEqual(charsTwo);
    }

    public void AnaList()
    {
      for(int i = 0; i < ComparisonWords.Length; i++)
      {
        if(AnaSorter(InitialWord, ComparisonWords[i]) == true)
        {
          // Console.WriteLine(ComparisonWords[i]);
          FinalOutput.Add(ComparisonWords[i]);
        }
      }
    }

    public List<string> GetOutput()
    {
      return FinalOutput;
    }
  }
}