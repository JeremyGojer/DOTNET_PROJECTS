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
        // If user is logged in, then allow access to cart
        string current_userid = HttpContext.Session.GetString("Current_User");
        if(current_userid != null){
        List<Cart> cart = cartServices.GetAllCarts(int.Parse(current_userid));
        this.ViewData["cart"] = cart;
        return View();
        }
        return RedirectToAction("Login","Account");
    }
    public IActionResult Delete(int id){
        cartServices.RemoveFromCart(cartServices.GetCartById(id));
         return RedirectToAction("Index", "ShoppingCart");
    }

    public IActionResult Edit(int id){
        string current_userid = HttpContext.Session.GetString("Current_User");
        var cartitem = cartServices.GetCartById(id);
        List<Cart> cart = cartServices.GetAllCarts(int.Parse(current_userid));
        this.ViewData["cart"] = cart;
        this.ViewData["cartitem"] = cartitem;
        return View();
    }

    public IActionResult Update(int id, int quantity){
        var cartitem = cartServices.GetCartById(id);
        cartitem.Quantity = quantity;
        cartServices.UpdateToCart(cartitem);
        return RedirectToAction("Index", "ShoppingCart");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
