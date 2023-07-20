using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Portfolio;

public class PortfolioList : ViewComponent
{
    PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
    
    public IViewComponentResult Invoke()
    {
        var values = portfolioManager.GetList();
        return View(values);
    }
}