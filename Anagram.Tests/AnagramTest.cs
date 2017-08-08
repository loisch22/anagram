using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagrams.Models;
using System;

namespace Anagrams.Tests
{
  [TestClass]
  public class AnagramTest : IDisposable
  {
    [TestMethod]
    public void GetWordInput_ReturnsInputtedWord_Top()
    {
      Anagram testAnagram = new Anagram("top", "");
      string expected = "top";
      string actual = testAnagram.GetWordInput();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CheckAnagram_ReturnsAnagram_Cat()
    {
      Anagram testAnagram = new Anagram("top","cat");
      List<string> expected = new List<string> {"not an anagram"};
      expected.ForEach(Console.WriteLine);
      List<string> actual = testAnagram.CheckAnagram();
      actual.ForEach(Console.WriteLine);
      CollectionAssert.AreEqual(expected, actual);
    }

    public void Dispose()
    {
      Anagram.ClearAll();
    }
  }
}
