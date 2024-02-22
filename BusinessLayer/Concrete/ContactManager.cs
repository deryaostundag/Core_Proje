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
        IContactDAL _ContactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _ContactDAL = contactDAL;
        }

        public void TAdd(Contact t)
        {
            _ContactDAL.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _ContactDAL.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _ContactDAL.GetByID(id);
        }

        public List<Contact> TGetList()
        {
            return _ContactDAL.GetList();
        }

        public void TUpdate(Contact t)
        {
            _ContactDAL.Update(t);
        }
    }
}
