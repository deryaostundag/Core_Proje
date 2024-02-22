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
    public class MessageManager : IMessageService
    {
        IMessageDAL _MessageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _MessageDAL = messageDAL;
        }

        public void TAdd(Message t)
        {
            _MessageDAL.Insert(t);
        }

        public void TDelete(Message t)
        {
            _MessageDAL.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _MessageDAL.GetByID(id);
        }

        public List<Message> TGetList()
        {
            return _MessageDAL.GetList();
        }

        public void TUpdate(Message t)
        {
            _MessageDAL.Update(t);
        }
    }
}
