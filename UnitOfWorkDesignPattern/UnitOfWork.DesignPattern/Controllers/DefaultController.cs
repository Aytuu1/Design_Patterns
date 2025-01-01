using BusinessLayer.DesignPattern.Abstract;
using EntityLayer.DesignPattern.Concrete;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.DesignPattern.Models;

namespace UnitOfWork.DesignPattern.Controllers
{
  public class DefaultController : Controller
  {
    private readonly ICustomerService _customerService;

    public DefaultController(ICustomerService customerService)
    {
      _customerService = customerService;
    }

    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Index(CustomerViewModel model)
    {
      var value = _customerService.TGetById(model.SenderID);
      var value2 = _customerService.TGetById(model.ReceiverID);

      value.CustomerBalance -= model.Amount;
      value2.CustomerBalance += model.Amount;

      List<Customer> modifiedCustomer = new List<Customer>()
      {
        value,
        value2
      };
      _customerService.TMultiUpdate(modifiedCustomer);


      return View();
    }













  }
}
