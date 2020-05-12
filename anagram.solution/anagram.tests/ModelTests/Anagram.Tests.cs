using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Anagram.Model;

namespace Anagram.Tests
{
  [TestClass]
  public class PhraseTests
  {
    [TestMethod]
    public void PhraseObIsCreated()
    {
      Phrase newPhrase = new Phrase();
      Assert.AreEqual(typeof(Phrase), newPhrase.GetType());
    }
    [TestMethod]
    public void SetPhrase_IntoString()
    {
      string phrase1 = "beard";
      string phrase2 = "bread";
      Phrase newPhrase = new Phrase(phrase1, phrase2);

      string updatedPhrase1 = "murder";
      string updatedPhrase2 = "redrum";
      newPhrase.Phrase1 = updatedPhrase1;
      newPhrase.Phrase2 = updatedPhrase2;

      string word = newPhrase;
      
      Assert.AreEqual(word, newPhrase);
 
    }
  }
}


// userInput1 = "bread"
// userInput2 = "beard"
// letterList1 = userInput.ToCharArray()
// letterList2 = userInput.ToCharArray()
// letterList1 output: ["b", "r", "e", "a", "d"]
// letterList2 output: ["b", "e", "a", "r", "d"]
// letterSort1 = Array.Sort(letterList);
// letterSort2 = Array.Sort(letterList);
// letterSort1 output: ["a", "b", "d", "e", "r"]
// letterSort2 output: ["a", "b", "d", "e", "r"]
// if letterSort1 == letterSort2
// 1) user inputs a word
// 2) users input is stored as a string
// 3) string is then turned into a LetterLIST array/list using charAt()?
// 4) use Array.Sort() to sort characters from LetterList alphabetically = LetterSort
// 5) program then puts it through a loop to see if LetterList == LetterSort
// 6) if true, add LetterList(i) to new list
// 7) return new list


// maybe select words are stored in a list of anagrams?