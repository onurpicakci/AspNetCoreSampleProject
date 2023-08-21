using AspNetCore_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Areas.Writer.Controllers;

[Area("Writer")]
public class ProfileController : Controller
{
    private readonly UserManager<WriterUser> _userManager;

    public ProfileController(UserManager<WriterUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var values= await _userManager.FindByNameAsync(User.Identity.Name);
        UserEditViewModel model = new UserEditViewModel();
        model.Name = values.Name;
        model.Surname = values.Surname;
        model.ImageUrl = values.ImageUrl;
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Index(UserEditViewModel model)
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);

        if (model.Image != null)
        {
            var resources = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resources + "/wwwroot/user-image/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            
            await model.Image.CopyToAsync(stream);
            user.ImageUrl = imageName;
        }

        user.Name = model.Name;
        user.Surname = model.Surname;

        var result = await _userManager.UpdateAsync(user);

        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Default");
        }
        else
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
        }

        return View();
    }
}