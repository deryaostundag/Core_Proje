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
        IServiceDAL _SerciveDAL;

        public ServiceManager(IServiceDAL serciveDAL)
        {
            _SerciveDAL = serciveDAL;
        }

        public void TAdd(Service t)
        {
            _SerciveDAL.Insert(t);
        }

        public void TDelete(Service t)
        {
            _SerciveDAL.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _SerciveDAL.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _SerciveDAL.GetList();
        }

        public void TUpdate(Service t)
        {
            _SerciveDAL.Update(t);
        }
    }
}
