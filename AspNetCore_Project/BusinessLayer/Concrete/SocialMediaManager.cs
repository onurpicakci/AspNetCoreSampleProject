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
    public class SocialMediaManager:ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void Add(SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }

        public void Delete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> GetList()
        {
          return  _socialMediaDal.GetList();
        }

        public List<SocialMedia> GetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Update(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
