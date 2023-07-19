using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetList();
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }

        public List<Contact> GetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
