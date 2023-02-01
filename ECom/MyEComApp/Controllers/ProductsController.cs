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
    private CategoryServices categoryServices = new CategoryServices();

    private CartServices cartServices = new CartServices();
   
    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index([FromQuery(Name="id")] int id)
    {   //int id = 1;
        var products = productServices.GetAllProducts(id);
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
        List<Category> categories = categoryServices.GetAllCategories();
        ViewData["categories"] = categories;
        return View();
    }

    [HttpPost]
    public IActionResult AddToCart(int productId, int quantity,double unitPrice){
        // If user is logged in then only allow to add items to cart
        string current_userid = HttpContext.Session.GetString("Current_User");
        if(current_userid != null){
            cartServices.AddToCart(new Cart(){UserId=int.Parse(current_userid),
                                              ProductId=productId,
                                              Quantity=quantity});
        return RedirectToAction("Index", "Products");
        }
        return RedirectToAction("Login","Account");
    }

    [HttpPost]
    public IActionResult Insert(string name, string description,double unitPrice,int quantity,string imageUrl, int categoryId){
        bool status = productServices.AddProduct(new Product(){Name=name,
                                                               Description=description,
                                                               UnitPrice=unitPrice,
                                                               Quantity=quantity,
                                                               ImageUrl=imageUrl,
                                                               CategoryId=categoryId});
        if(status){
            Console.WriteLine("New Item Added");
            return RedirectToAction("Index", "Products");
        }
        return View();
    }

    public IActionResult Delete(int id){
        productServices.RemoveProduct(productServices.GetProductById(id));
         return RedirectToAction("Index", "Products");
    }
    public IActionResult Edit(int id){
        var product = productServices.GetProductById(id);
        this.ViewData["product"] = product;
        return View();
    }
    
    public IActionResult Update(int id, string name, string description,double unitPrice,int quantity,string imageUrl){
        Product product = productServices.GetProductById(id);
        product.Name = name;
        product.Description = description;
        product.UnitPrice = unitPrice;
        product.Quantity = quantity;
        product.ImageUrl = imageUrl;
        productServices.UpdateProduct(product);
        return RedirectToAction("Index", "Products");
    }

    public IActionResult SortByName(){
        productServices.SortByName();
        return RedirectToAction("Index","Products");
    }

    public IActionResult SortByPrice(){
        productServices.SortByPrice();
        return RedirectToAction("Index","Products");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
