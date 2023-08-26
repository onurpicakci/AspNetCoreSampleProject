using AspNetCore_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Areas.Writer.Controllers;

[Area("Writer")]
[Route("Writer/[controller]/[action]")]

public class RegisterController : Controller
{
    private readonly UserManager<WriterUser> _userManager;

    public RegisterController(UserManager<WriterUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View(new UserRegisterViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> Index(UserRegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            WriterUser user = new()
            {
                Name = model.Name,
                Surname = model.Surname,
                UserName = model.UserName,
                Email = model.Email,
                ImageUrl = model.ImageUrl
            };
            if (model.Password == model.PasswordConfirm)
            {
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
        }

        return View(model);
    }
}