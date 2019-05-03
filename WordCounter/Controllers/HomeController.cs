using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
