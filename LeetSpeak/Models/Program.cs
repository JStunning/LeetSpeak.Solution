using System;
using System.Collections.Generic;
using LeetSpeak.Models;

public class Program
{

  public static Speak mySpeak;
  public static void Main()
  {
    mySpeak = new Speak();
    Console.WriteLine("Hello enter word you want to be LEET");
    string setThisText = Console.ReadLine();
    mySpeak.SetSplit(setThisText);
    string str = new String(mySpeak.Split);
    Console.WriteLine(str);
  }


}