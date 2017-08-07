using Microsoft.AspNetCore.Mvc;
using LeetSpeak.Models;
using System.Collections.Generic;
using System;

namespace LeetSpeak.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index ()
    {
      return View();
    }
    [HttpPost("/leetSpeak")]
    public ActionResult LeetSpeakResult ()
    {
      string userInput = Request.Form["english"];
      LeetSpeaker speaker = new LeetSpeaker(userInput);
      return View(speaker);
    }
  }
}
