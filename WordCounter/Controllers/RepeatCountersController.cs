using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class RepeatCountersController : Controller
  {
    [HttpGet("/repeatcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/repeatcounter")]
    public ActionResult Create(string phrase, string target)
    {
      RepeatCounter newRepeatCounter = new RepeatCounter(target, phrase, false);
      return View("Show", newRepeatCounter);
    }

    [HttpGet("/repeatcounter/{id}")]
    public ActionResult Show(int id)
    {

      return View();
    }

  }
}
