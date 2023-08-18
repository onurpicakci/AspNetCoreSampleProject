using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Portfolio;

public class SlideList : ViewComponent
{
    PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());
    
    public IViewComponentResult Invoke()
    {
        var values = _portfolioManager.GetList();
        return View(values);
    }
}