using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
      [Route("/hello2")]
      public string Hello2() { return "Hello friend!"; }

      [Route("/goodbye")]
      public string Goodbye() { return "Goodbye friend."; }

       [Produces("text/html")]
      [Route("/letter")]
      [Route("/")]
        public ActionResult Letter()
        {
            return View();
        }

        [Route("/journal")]
        public ActionResult Journal()
        {
          return View();
        }

        [Route("/hello")]
        public ActionResult Hello()
        {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient("Eric");
          myLetterVariable.SetSender("John");
          return View(myLetterVariable);
        }

        [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }

        [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("Hello", myLetterVariable);
        }

  }
}
