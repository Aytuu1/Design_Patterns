using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Repository_DesignPattern.Controllers
{

  public class ProductController : Controller
  {
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;
    public ProductController(IProductService productService, ICategoryService categoryService)
    {
      _productService = productService;
      _categoryService = categoryService;
    }

    public IActionResult Index()
    {
      
      var values = _productService.TProductListWithCategory();
      return View(values);
    }
    [HttpGet]

    
    public IActionResult AddProduct()
    {
      List<SelectListItem> values = (from x in _categoryService.TGetList()
                                     select new SelectListItem
                                     {
                                       Text = x.CategoryName,
                                       Value = x.CategoryID.ToString(),
                                     }).ToList();
      ViewBag.Category = values;
      return View();

    }
    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
      _productService.TInsert(product);
      return RedirectToAction("Index");

    }

    public IActionResult DeleteProduct(int id)
    {
      var deletedValue = _productService.TGetById(id);
      _productService.TDelete(deletedValue);
      return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult UpdateProduct(int id)
    {
      var updateValue = _productService.TGetById(id);
      List<SelectListItem> value = (from x in _categoryService.TGetList()
                                    select new SelectListItem
                                    {
                                      Text = x.CategoryName,
                                      Value = x.CategoryID.ToString(),
                                    }).ToList();
      ViewBag.CategoryName = value;

      return View(updateValue);
    }

    [HttpPost]
    public IActionResult UpdateProduct(Product product)
    {
      _productService.TUpdate(product);
      return RedirectToAction("Index");
    }

  




  }
}
