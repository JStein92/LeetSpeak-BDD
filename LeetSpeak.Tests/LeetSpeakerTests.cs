using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LeetSpeak.Models;
using System;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakerTest
  {
    [TestMethod]
    public void LeetSpeaker_ReplaceEWith3_String()
    {
      //Arrange
      string expected = "3";
      //Act
      LeetSpeaker testSpeaker = new LeetSpeaker("e");
      string actual = testSpeaker.LeetSpeakConverter();
      //Assert
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void LeetSpeaker_ReplaceOwith0_String()
    {
      //Arrange
      string expected = "30";
      //Act
      LeetSpeaker testSpeaker = new LeetSpeaker("eo");
      string actual = testSpeaker.LeetSpeakConverter();
      //Assert
      Assert.AreEqual(expected,actual);
    //  Console.WriteLine("Actual string returned: " + actual);
    }
    [TestMethod]
    public void LeetSpeaker_ReplaceIwith1_String()
    {
      //Arrange
      string expected = "301";
      //Act
      LeetSpeaker testSpeaker = new LeetSpeaker("eoI");
      string actual = testSpeaker.LeetSpeakConverter();
      //Assert
      Assert.AreEqual(expected,actual);
      //Console.WriteLine("Actual string returned: " + actual);
    }
    [TestMethod]
    public void LeetSpeaker_Replacetwith7_String()
    {
      //Arrange
      string expected = "3017";
      //Act
      LeetSpeaker testSpeaker = new LeetSpeaker("eoIt");
      string actual = testSpeaker.LeetSpeakConverter();
      //Assert
      Assert.AreEqual(expected,actual);
    //  Console.WriteLine("Actual string returned: " + actual);
    }
    [TestMethod]
    public void LeetSpeaker_Replaceswithz_String()
    {
      //Arrange
      string expected = "s3017z";
      //Act
      LeetSpeaker testSpeaker = new LeetSpeaker("seoIts");
      string actual = testSpeaker.LeetSpeakConverter();
      //Assert
      Assert.AreEqual(expected,actual);
      //Console.WriteLine("Actual string returned: " + actual);
    }
    [TestMethod]
    public void LeetSpeaker_ReplaceSentence_String()
    {
      //Arrange
      string expected = "D0n'7 y0u l0v3 7h3z3 'String' 3x3rciz3z? 1 d0!";
      //Act
      LeetSpeaker testSpeaker = new LeetSpeaker("Don't you love these 'String' exercises? I do!");
      string actual = testSpeaker.LeetSpeakConverter();
      //Assert
      Assert.AreEqual(expected,actual);
      Console.WriteLine("Actual string returned: " + actual);
    }
  }
}
