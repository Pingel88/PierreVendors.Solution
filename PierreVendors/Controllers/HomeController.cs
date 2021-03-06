using Microsoft.AspNetCore.Mvc;

namespace PierreVendors.Controllers
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