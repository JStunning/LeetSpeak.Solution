using System;
using System.Collections.Generic;

namespace LeetSpeak.Models
{
  public class Speak
  {
    public char[] Split;

    public void SetSplit(string userText)
    {
      Split = userText.ToCharArray();
      ReplaceLeet();
    }

    public void ReplaceLeet()
    {
      for (int i = 0; i < Split.Length; i++)
      {
        Console.WriteLine(Split[i]);
        if (Split[i].Equals('e'))
        {
          Split[i] = char.Parse("3");
        }
        else if (Split[i].Equals('o'))
        {
          Split[i] = char.Parse("0");
        }
        else if (Split[i].Equals('t'))
        {
          Split[i] = char.Parse("7");
        }
        else if (Split[i].Equals('s'))
        {
          Split[i] = char.Parse("z");
        }
        else if (Split[i].Equals('L'))
        {
          Split[i] = char.Parse("1");
        }
      }
    }
  }
}