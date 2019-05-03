using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
  public class RepeatCountersController : Controller
  {
    [Route("/repeatcounter/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
