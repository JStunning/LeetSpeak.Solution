using LeetSpeak.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeetSpeak.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    // mySpeak = new Speak();
    // Console.WriteLine("Hello enter word you want to be LEET");
    // string setThisText = Console.ReadLine();
    // mySpeak.SetSplit(setThisText);
    // string str = new String(mySpeak.Split);
    // Console.WriteLine(str);

    [Route("/result")]
    public ActionResult Result(string word)
    {
      Speak leetSpeak = new Speak();
      leetSpeak.SetSplit(word);
      return View(leetSpeak);
    }
  }
}