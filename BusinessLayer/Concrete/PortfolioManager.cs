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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDAL _PortfolioDAL;

        public PortfolioManager(IPortfolioDAL portfolioDAL)
        {
            _PortfolioDAL = portfolioDAL;
        }

        public void TAdd(Portfolio t)
        {
            _PortfolioDAL.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _PortfolioDAL.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _PortfolioDAL.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
            return _PortfolioDAL.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _PortfolioDAL.Update(t);
        }
    }
}
