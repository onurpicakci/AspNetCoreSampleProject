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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature entity)
        {
            _featureDal.Insert(entity);
        }

        public void Delete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public void Update(Feature entity)
        {
            _featureDal.Update(entity);
        }

        public List<Feature> GetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
