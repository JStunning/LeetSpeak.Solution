using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak.Models;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class SpeakTests
  {
    // Test methods go here
    [TestMethod] //1
    public void SetSplit_SetSplitWithParam_true()
    {
      Speak testSpeak = new Speak();
      testSpeak.SetSplit("Hello");
      Assert.AreEqual(char.Parse("H"), testSpeak.Split[0]);
    }

    [TestMethod] //2
    public void ReplaceLeet_ReplaceE_3()
    {
      Speak testSpeak = new Speak();
      testSpeak.SetSplit("e");
      Assert.AreEqual(char.Parse("3"), testSpeak.Split[0]);
    }

    [TestMethod] //3
    public void ReplaceLeet_ReplaceO_0()
    {
      Speak testSpeak = new Speak();
      testSpeak.SetSplit("o");
      Assert.AreEqual(char.Parse("0"), testSpeak.Split[0]);
    }

    [TestMethod] //4
    public void ReplaceLeet_ReplaceT_7()
    {
      Speak testSpeak = new Speak();
      testSpeak.SetSplit("t");
      Assert.AreEqual(char.Parse("7"), testSpeak.Split[0]);
    }

    [TestMethod] //5
    public void ReplaceLeet_ReplaceS_Z()
    {
      Speak testSpeak = new Speak();
      testSpeak.SetSplit("s");
      Assert.AreEqual(char.Parse("z"), testSpeak.Split[0]);
    }

    [TestMethod] //6
    public void ReplaceLeet_ReplaceHello_H3ll0()
    {
      Speak testSpeak = new Speak();
      testSpeak.SetSplit("Hello");
      string str = new String(testSpeak.Split);
      Assert.AreEqual("H3ll0", str);
    }

    [TestMethod] // 7
    public void ReplaceLeet_ReplaceHeLLo_H3110()
    {
      Speak testSpeak = new Speak();
      testSpeak.SetSplit("HeLLo");
      string str = new String(testSpeak.Split);
      Assert.AreEqual("H3110", str);
    }

  }
}