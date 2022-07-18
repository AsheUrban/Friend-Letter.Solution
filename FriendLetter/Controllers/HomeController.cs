using Microsoft.AspNetCore.Mvc; // inherit or extend functionality for Controller
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller // call on functionality here
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye Friend."; }

    [Route("/")]
    public ActionResult Letter() 
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string destination, string souvenirs, string activity)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Destination = destination;
      myLetterVariable.Souvenirs = souvenirs;
      myLetterVariable.Activity = activity;
      return View(myLetterVariable);
    }
  }
}