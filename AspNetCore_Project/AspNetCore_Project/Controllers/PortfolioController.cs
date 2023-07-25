using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
        portfolioManager.Add(portfolio);
        return RedirectToAction("Index");
    }
}