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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void Delete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public List<Service> GetList()
        {
            return _serviceDal.GetList();
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void Update(Service entity)
        {
            _serviceDal.Update(entity);
        }

        public List<Service> GetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
