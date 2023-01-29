using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using SAL;
namespace TFLStore.Controllers;

public class AccountController : Controller{
    private readonly ILogger<AccountController> _logger;
    private UserServices userServices = new UserServices();
    public AccountController(ILogger<AccountController> _logger){
        this._logger = _logger;
    }
    [HttpGet]
    public IActionResult Login(){
        return View();
    }
    [HttpPost]
    public IActionResult Login(string email, string password){
        bool status = userServices.Authenticate(email,password);
        if(status){
            return RedirectToAction("Index", "Products");
        }
        return View();
    }
    public IActionResult Register(){
        return View();
    }
    [HttpPost]
    public IActionResult Register(string firstName,string lastName,string email,string password,string contactNumber){
        bool status = userServices.Register(firstName,lastName,email,password,contactNumber);
        if(status){
            return RedirectToAction("Login", "Account");
        }
        return View();
    }
}