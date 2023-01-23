using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyECommerceApp.Models;

namespace MyECommerceApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Catalog()
    {
        return View();
    }
    public IActionResult Result(string search)
    {
        if(search=="Electronics"){
            return RedirectToAction("Electronics","Products");
        }
        return View();
    }
    public IActionResult Electronics()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
