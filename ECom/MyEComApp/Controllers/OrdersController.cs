using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using SAL;
using BOL;

namespace TFLStore.Controllers;

public class OrdersController : Controller
{
    private readonly ILogger<OrdersController> _logger;
    private OrderServices orderServices = new OrderServices();

    public OrdersController(ILogger<OrdersController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        int userid = int.Parse(HttpContext.Session.GetString("Current_User"));
        List<Order> orders = orderServices.GetAllForUser(userid);
        ViewData["orders"] = orders;
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
