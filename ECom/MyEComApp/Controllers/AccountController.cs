using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using SAL;
namespace TFLStore.Controllers;

public class AccountController : Controller{
    private readonly ILogger<AccountController> _logger;
    private UserServices userServices = new UserServices();
    private TwilioServices twilioServices = new TwilioServices();
    public AccountController(ILogger<AccountController> _logger){
        this._logger = _logger;
    }
    [HttpGet]
    public IActionResult Login(){
        return View();
    }
    [HttpPost]
    public IActionResult Login(string email, string password){
        string userid = userServices.Authenticate(email,password);
        if(userid != ""){
            HttpContext.Session.SetString("Current_User",userid);
            return RedirectToAction("Index", "Home");
        }
        ViewData["msg"] = "Incorrect Email or Passowrd, Please check your credentials again";
        return View();
    }
    public IActionResult LogOut(){
        HttpContext.Session.Remove("Current_User");
        return RedirectToAction("Login", "Account");;
    }
    public IActionResult Register(){
        return View();
    }
    [HttpPost]
    public IActionResult Register(string firstName,string lastName,string email,string password,string contactNumber, int roleid){
        bool status = userServices.Register(firstName,lastName,email,password,contactNumber,roleid);
        if(status){
            
            return RedirectToAction("Login", "Account");
            //Uncomment to use twilio otp service 
            //HttpContext.Session.SetString("contactnumber",contactNumber);
            //return RedirectToAction("VerifyOTP", "Account");
        }
        return View();
    }
    public IActionResult VerifyOTP(){
        string contactnumber = HttpContext.Session.GetString("contactnumber");
        string otp = twilioServices.SendOTP(contactnumber);
        HttpContext.Session.SetString("otp",otp);
        return View();
    }

    [HttpPost]
    public IActionResult VerifyOTP(string otp){
        string otp1 = HttpContext.Session.GetString("otp");
        Console.WriteLine(otp1);
        if(otp == otp1){
            return RedirectToAction("Login", "Account");
        }
        ViewData["msg"] = "Incorrect OTP, Please try again";
        return View();
    }
}