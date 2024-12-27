using DesignPattern_TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern_TemplateMethod.Controllers
{
  public class DefaultController : Controller
  {
    public IActionResult BasıcPlanIndex()
    {
      NetflixPlans netflixPlans = new BasicPlan();
      ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
      ViewBag.v2 = netflixPlans.CountPerson(1);
      ViewBag.v3 = netflixPlans.Price(65.88m);
      ViewBag.v4 = netflixPlans.Content("Film-Dizi");
      ViewBag.v5 = netflixPlans.Resolution("480px");


      return View();
    }
    public IActionResult StandartPlanIndex()
    {
      NetflixPlans netflixPlans = new StandardPlan();
      ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
      ViewBag.v2 = netflixPlans.CountPerson(3);
      ViewBag.v3 = netflixPlans.Price(125.99m);
      ViewBag.v4 = netflixPlans.Content("Film-Dizi");
      ViewBag.v5 = netflixPlans.Resolution("720px");


      return View();
    }
    public IActionResult UltraPlanIndex()
    {
      NetflixPlans netflixPlans = new UltraPlan();
      ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
      ViewBag.v2 = netflixPlans.CountPerson(7);
      ViewBag.v3 = netflixPlans.Price(155.99m);
      ViewBag.v4 = netflixPlans.Content("Film-Dizi-Animasyon");
      ViewBag.v5 = netflixPlans.Resolution("1720px");


      return View();
    }
  }
}
