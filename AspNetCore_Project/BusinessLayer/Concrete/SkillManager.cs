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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Add(Skill entity)
        {
            _skillDal.Insert(entity);
        }

        public void Delete(Skill entity)
        {
            _skillDal.Delete(entity);
        }

        public List<Skill> GetList()
        {
            return _skillDal.GetList();
        }

        public Skill GetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public void Update(Skill entity)
        {
            _skillDal.Update(entity);
        }

        public List<Skill> GetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
