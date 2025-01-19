using Iterator.DesignPattern.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace Iterator.DesignPattern.Controllers
{
  public class DefaultController : Controller
  {
    public IActionResult Index()
    {
      VisitRouteMover visitRouteMover = new VisitRouteMover();
      List<string> strings = new List<string>();


      visitRouteMover.addVisitRoute(new VisitRoute
      {
        CountryName = "Almanya",
        CityName = "Berlin",
        VisitPlaceName = "Berlin Kapısı"
      });
      visitRouteMover.addVisitRoute(new VisitRoute
      {
        CountryName = "Fransa",
        CityName = "Paris",
        VisitPlaceName = "Eyfel Kulesi"
      });
      visitRouteMover.addVisitRoute(new VisitRoute
      {
        CountryName = "İtalya",
        CityName = "Venedik",
        VisitPlaceName = "Gondol"
      });
      visitRouteMover.addVisitRoute(new VisitRoute
      {
        CountryName = "İtalya",
        CityName = "Roma",
        VisitPlaceName = "Kolezyum"
      });
      visitRouteMover.addVisitRoute(new VisitRoute
      {
        CountryName = "Çek Cumhuriyeti",
        CityName = "Prag",
        VisitPlaceName = "Meydan"
      });

      var iterator = visitRouteMover.CreateIterator();
      while (iterator.NextLocation())
      {
        strings.Add(iterator.CurrentItem.CountryName + " - " + iterator.CurrentItem.CityName + " - " + iterator.CurrentItem.VisitPlaceName);
      }
      ViewBag.v = strings;
      return View();
    }













  }
}
