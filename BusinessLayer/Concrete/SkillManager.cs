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
        ISkillDAL _SkillDAL;

        public SkillManager(ISkillDAL skillDAL)
        {
            _SkillDAL = skillDAL;
        }

        public void TAdd(Skill t)
        {
            _SkillDAL.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _SkillDAL.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _SkillDAL.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return _SkillDAL.GetList();
        }

        public void TUpdate(Skill t)
        {
            _SkillDAL.Update(t);
        }
    }
}
