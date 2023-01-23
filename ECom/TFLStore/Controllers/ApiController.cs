using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
namespace TFLStore.Controllers;
using SAL;

public class ApiController : Controller{
    private readonly ILogger<ApiController> _logger;
    private IProductServices productServices = new ProductServices();
    private UserServices userServices = new UserServices();
    public ApiController(ILogger<ApiController> _logger){
        this._logger = _logger;
    }
    public IActionResult Index(){
        return View();
    }
    public IActionResult Products()
    {
        var products = productServices.DisplayAllProducts();
        return Json(products);
    }
    public IActionResult Users()
    {
        var products = userServices.DisplayAllUsers();
        return Json(products);
    }
    
}