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
    public ActionResult Create(string phrase, string target, bool casesensitive = false)
    {
      RepeatCounter newRepeatCounter = new RepeatCounter(target, phrase, casesensitive);
      return View("Show", newRepeatCounter);
    }

    [HttpGet("/repeatcounter/{id}")]
    public ActionResult Show(int id)
    {
      RepeatCounter myRepeatCounter = RepeatCounter.Find(id);
      return View(myRepeatCounter);
    }

    [HttpPost("/repeatcounter/clearhistory")]
    public ActionResult Delete()
    {
      RepeatCounter.ClearHistory();
      return RedirectToAction("New");
    }

  }
}
