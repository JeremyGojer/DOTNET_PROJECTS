using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using SAL;
using BOL;

namespace TFLStore.Controllers;

public class ShoppingCartController : Controller
{
    private readonly ILogger<ShoppingCartController> _logger;
    private CartServices cartServices = new CartServices();


    public ShoppingCartController(ILogger<ShoppingCartController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        List<Cart> cart = cartServices.GetAllCarts();
        this.ViewData["cart"] = cart;
        return View();
    }
    public IActionResult AddToCart(){
        return RedirectToAction("Index", "Products");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
