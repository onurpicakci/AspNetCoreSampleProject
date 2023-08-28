using AspNetCore_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Areas.Writer.Controllers;

[Area("Writer")]
[Route("Writer/[controller]/[action]")]
[AllowAnonymous]

public class LoginController : Controller
{
    private readonly SignInManager<WriterUser> _signInManager;

    public LoginController(SignInManager<WriterUser> signInManager)
    {
        _signInManager = signInManager;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Index(UserLoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, true, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is incorrect");
                return View("Index");
            }
        }
        return View();
    }
    
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Login");
    }
}