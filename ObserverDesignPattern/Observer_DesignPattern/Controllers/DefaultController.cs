using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Observer_DesignPattern.DAL;
using Observer_DesignPattern.Models;

namespace Observer_DesignPattern.Controllers
{

  public class DefaultController : Controller
  {
    private readonly UserManager<AppUser> _userManager;

    public DefaultController(UserManager<AppUser> userManager)
    {
      _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(RegisterViewModel model)
    {
      var appUser = new AppUser()
      {
        Name = model.Name,
        Email = model.Email,
        Surname = model.Surname,
        UserName = model.UserName,
        City=model.City,
        District = model.District,
      };
      await _userManager.CreateAsync(appUser, model.Password);
      return View();
    }


















  }
}
