using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Ana.ClearAll();
    }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfAna_Ana()
    {
      Ana newWord = new Ana("input", "words");
      Assert.AreEqual(typeof(Ana), newWord.GetType());
    }

    [TestMethod]
    public void ItemConstructor_StoresInputWordCorrectly_Input()
    {
      string input = "input";
      Ana newWord = new Ana(input, "words");
      Assert.AreEqual(input, newWord.InitialWord);
    }

    [TestMethod]
    public void ItemConstructor_StoresWordArrayCorrectly_Array()
    {
      string[] words = {"this", "that", "those"};
      Ana newWord = new Ana("input", "this that those");
      CollectionAssert.AreEqual(words, newWord.ComparisonWords);
    }

    [TestMethod]
    public void AnaSorter_SplitSortCorrectly_True()
    {
      string wordOne = "words";
      string WordTwo = "sword";
      Ana newWord = new Ana(wordOne, WordTwo);
      bool output = newWord.AnaSorter(newWord.InitialWord, newWord.ComparisonWords[0]);
      Assert.AreEqual(true, output);
    }

    [TestMethod]
    public void AnaSorter_PopulatesListCorrectly_List()
    {
      List<string> correctList = new List<string> {"slit", "silt"};
      Ana newWord = new Ana("list", "slit silt banana butts");
      newWord.AnaList();
      CollectionAssert.AreEqual(correctList, newWord.GetOutput());
    }
  }
}