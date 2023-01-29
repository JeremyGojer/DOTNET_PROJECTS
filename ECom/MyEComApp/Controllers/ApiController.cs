using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
namespace TFLStore.Controllers;
using SAL;
using BOL;

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
    [HttpGet]//Display All Products
    public IActionResult Products()
    {
        var products = productServices.GetAllProducts();
        return Json(products);
    }

    [HttpPut]//Add products
    public IActionResult Products(Product product)
    {
        bool status = productServices.AddProduct(product);
        if(status==true){
            return Json(product);    
        }
        return Json("Not Added");
    }
    // [HttpDelete]//Delete products
    // public IActionResult Products(Product product)
    // {
    //     bool status = productServices.RemoveProduct(product);
    //     if(status==true){
    //         return Json(product);    
    //     }
    //     return Json("Not removed");
    // }
    public IActionResult Users()
    {
        var products = userServices.DisplayAllUsers();
        return Json(products);
    }
    
}