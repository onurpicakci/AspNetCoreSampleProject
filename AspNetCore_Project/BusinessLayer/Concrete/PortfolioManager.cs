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
   public class PortfolioManager:IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void Add(Portfolio entity)
        {
            _portfolioDal.Insert(entity);
        }

        public void Delete(Portfolio entity)
        {
            _portfolioDal.Delete(entity);
        }

        public List<Portfolio> GetList()
        {
            return _portfolioDal.GetList();
        }

        public Portfolio GetById(int id)
        {
            return _portfolioDal.GetById(id);
        }

        public void Update(Portfolio entity)
        {
            _portfolioDal.Update(entity);
        }

        public List<Portfolio> GetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
