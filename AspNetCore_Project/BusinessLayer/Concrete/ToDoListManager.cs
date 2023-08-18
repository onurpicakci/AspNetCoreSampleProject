using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;
 
public class ToDoListManager : IToDoListService
{
    IToDoListDal _toDoListDal;

    public ToDoListManager(IToDoListDal toDoListDal)
    {
        _toDoListDal = toDoListDal;
    }
    
    public void Add(ToDoList entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(ToDoList entity)
    {
        throw new NotImplementedException();
    }

    public void Update(ToDoList entity)
    {
        throw new NotImplementedException();
    }

    public List<ToDoList> GetList()
    {
       return  _toDoListDal.GetList();
    }

    public ToDoList GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<ToDoList> GetListbyFilter()
    {
        throw new NotImplementedException();
    }
}