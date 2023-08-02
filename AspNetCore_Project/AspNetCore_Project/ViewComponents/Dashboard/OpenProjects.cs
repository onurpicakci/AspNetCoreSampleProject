using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class OpenProjects : ViewComponent
{
    PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
    
    public IViewComponentResult Invoke()
    {
        var values = portfolioManager.GetLastFiveProjects();
        return View(values);
    }
}