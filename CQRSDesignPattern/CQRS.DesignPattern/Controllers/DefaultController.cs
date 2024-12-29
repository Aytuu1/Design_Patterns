using CQRS.DesignPattern.CQRSPattern.Commands;
using CQRS.DesignPattern.CQRSPattern.Handlers;
using CQRS.DesignPattern.CQRSPattern.Quiries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.DesignPattern.Controllers
{
  public class DefaultController : Controller
  {
    private readonly GetProductQueryHandler _handler;
    private readonly CreateProductCommandHandler _commandHandler;
    private readonly GetProductByIdQueryHandler _getProductByIdqueryHandler;
    private readonly RemoveProductCommandHandler _removeProductHandler;
    private readonly GetProductUpdateByIdQueryHandler _getProductUpdateByIdHandler;
    private readonly UpdateProductCommandHandler _updateProductCommandHandler;

    public DefaultController(CreateProductCommandHandler commandHandler, GetProductQueryHandler handler, GetProductByIdQueryHandler getProductByIdqueryHandler, RemoveProductCommandHandler removeProductHandler, GetProductUpdateByIdQueryHandler getProductUpdateByIdHandler, UpdateProductCommandHandler updateProductByIdHandler)
    {
      _commandHandler = commandHandler;
      _handler = handler;
      _getProductByIdqueryHandler = getProductByIdqueryHandler;
      _removeProductHandler = removeProductHandler;
      _getProductUpdateByIdHandler = getProductUpdateByIdHandler;
      _updateProductCommandHandler = updateProductByIdHandler;
    }

    public IActionResult Index()
    {
      var values = _handler.Handle();
      return View(values);
    }
    [HttpGet]
    public IActionResult AddProduct()
    {
      return View();
    }
    [HttpPost]
    public IActionResult AddProduct(CreateProductCommand command)
    {
      _commandHandler.Handle(command);
      return RedirectToAction("Index");
    }
    public IActionResult GetProduct(int id)
    {
      var values = _getProductByIdqueryHandler.Handle(new GetProductByIdQuery(id));
      return View(values);
    }
    public IActionResult DeleteProduct(int id)
    {
      _removeProductHandler.Handle(new RemoveProductCommand(id));
      return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult UpdateProduct(int id)
    {
      var values = _getProductUpdateByIdHandler.Handle(new GetProductUpdateByIDQuery(id));
      return View(values);
    }
    [HttpPost]
    public IActionResult UpdateProduct(UpdateProductCommand command)
    {
      _updateProductCommandHandler.Handler(command);
      return RedirectToAction("index");
    }
  }
}
