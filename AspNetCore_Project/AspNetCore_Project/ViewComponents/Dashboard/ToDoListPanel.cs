using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Project.ViewComponents.Dashboard;

public class ToDoListPanel : ViewComponent
{
    ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
    
    public IViewComponentResult Invoke()
    {
        var values = toDoListManager.GetList();
        return View(values);
    }
}