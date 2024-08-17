using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscibeService
    {
        private readonly ISubscripeDal _subscripeDal;

        public SubscribeManager(ISubscripeDal subscripeDal)
        {
            _subscripeDal = subscripeDal;
        }

        public void TDelete(Subscribe t)
        {
            _subscripeDal.Delete(t);
        }

        public Subscribe TGetByID(int id)
        {
            return _subscripeDal.GetByID(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscripeDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            _subscripeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscripeDal.Update(t);
        }
    }
}
