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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDAL _ExperienceDAL;

        public ExperienceManager(IExperienceDAL experienceDAL)
        {
            _ExperienceDAL = experienceDAL;
        }

        public void TAdd(Experience t)
        {
            _ExperienceDAL.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _ExperienceDAL.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return _ExperienceDAL.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _ExperienceDAL.GetList();
        }

        public void TUpdate(Experience t)
        {
            _ExperienceDAL.Update(t);
        }
    }
}
