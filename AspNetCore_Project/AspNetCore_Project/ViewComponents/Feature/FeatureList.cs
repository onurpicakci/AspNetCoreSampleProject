using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Feature;

public class FeatureList : ViewComponent
{
    
    FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
    
    public IViewComponentResult Invoke()
    {
        var values = featureManager.GetList();
        return View(values);
    }
}