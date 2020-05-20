using Microsoft.AspNetCore.Mvc;

namespace PlacesWB.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}