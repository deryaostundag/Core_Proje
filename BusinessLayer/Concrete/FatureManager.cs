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
    public class FatureManager : IFeatureService
    {
        IFeatureDAL _FeatureDAL;

        public FatureManager(IFeatureDAL featureDAL)
        {
            _FeatureDAL = featureDAL;
        }

        public void TAdd(Feature t)
        {
            _FeatureDAL.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _FeatureDAL.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return _FeatureDAL.GetByID(id);
        }

        public List<Feature> TGetList()
        {
            return _FeatureDAL.GetList();
        }

        public void TUpdate(Feature t)
        {
            _FeatureDAL.Update(t);
        }
    }
}
