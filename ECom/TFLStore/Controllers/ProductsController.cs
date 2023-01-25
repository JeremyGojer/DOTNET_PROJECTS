using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using SAL;
using BOL;

namespace TFLStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;
    private IProductServices productServices = new ProductServices();


    //parameterized constructor is always used for Dependency Injection
    //1.Constructor DI
    //2.Property DI
    //3.Method DI
    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var products = productServices.GetAllProducts();
        this.ViewData["products"] = products;
        return View();
    }
    

    public IActionResult Details(int id)
    {
        var product = productServices.GetProductById(id);
        this.ViewData["productDetails"] = product;
        return View();
    }

    public IActionResult Insert(){
        return View();
    }
    [HttpPost]
    public IActionResult Insert(string name, string description,double unitPrice,int quantity,string imageUrl){
        bool status = productServices.AddProduct(new Product(name,description,unitPrice,quantity,imageUrl));
        if(status){
            Console.WriteLine("New Item Added");
            return RedirectToAction("Index", "Products");
        }
        return View();
    }

    public IActionResult Delete(){
         return View();
    }
    
    public IActionResult Update(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
