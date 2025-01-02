using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Repository_DesignPattern.Controllers
{
  public class CategoryController : Controller
  {
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
      _categoryService = categoryService;
    }

    public IActionResult Index()
    {
      var values = _categoryService.TGetList();
      return View(values);
    }

    [HttpGet]
    public IActionResult AddCategory()
    {

      return View();

    }
    [HttpPost]
    public IActionResult AddCategory(Category category)
    {
      _categoryService.TInsert(category);
      return RedirectToAction("Index");

    }

    public IActionResult DeleteCategory(int id)
    {
      var deletedValue = _categoryService.TGetById(id);
      _categoryService.TDelete(deletedValue);
      return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult UpdateCategory(int id)
    {
      var updateValue = _categoryService.TGetById(id);
      return View(updateValue);
    }

    [HttpPost]
    public IActionResult UpdateCategory(Category category)
    {
      _categoryService.TUpdate(category);
      return RedirectToAction("Index");
    }










  }
}
