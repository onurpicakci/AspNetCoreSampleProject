using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.Controllers;

public class PortfolioController : Controller
{
    PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

    public IActionResult Index()
    {
        ViewBag.v1 = "Portfolio List";
        ViewBag.v2 = "Portfolios";
        ViewBag.v3 = "Portfolio List";
        var values = portfolioManager.GetList();
        return View(values);
    }

    [HttpGet]
    public IActionResult AddPortfolio()
    {
        ViewBag.v1 = "Add New Portfolio";
        ViewBag.v2 = "Portfolios";
        ViewBag.v3 = "Add New Portfolio";
        return View();
    }

    [HttpPost]
    public IActionResult AddPortfolio(Portfolio portfolio)
    {
        PortfolioValidator portfolioValidator = new PortfolioValidator();
        ValidationResult result = portfolioValidator.Validate(portfolio);

        if (result.IsValid)
        {
            portfolioManager.Add(portfolio);
            return RedirectToAction("Index");
        }
        else
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
        }

        return View();
    }
    
    public IActionResult DeletePortfolio(int id)
    {
        var portfolioValue = portfolioManager.GetById(id);
        portfolioManager.Delete(portfolioValue);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult UpdatePortfolio(int id)
    {
        ViewBag.v1 = "Update Portfolio";
        ViewBag.v2 = "Portfolios";
        ViewBag.v3 = "Update Portfolio";
        var portfolioValue = portfolioManager.GetById(id);
        return View(portfolioValue);
    }
    
    [HttpPost]
    public IActionResult UpdatePortfolio(Portfolio portfolio)
    {
        PortfolioValidator portfolioValidator = new PortfolioValidator();
        ValidationResult result = portfolioValidator.Validate(portfolio);

        if (result.IsValid)
        {
            portfolioManager.Update(portfolio);
            return RedirectToAction("Index");
        }
        else
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
        }
        return View();
    }
}