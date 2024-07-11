using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class AdressManager : IAdressService
    {
        private readonly IAddressDal _addressDal;

        public AdressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public Adress GTetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public void TDelete(int id)
        {
            _addressDal.Delete(id);
        }

        public List<Adress> TGetAll()
        {
            return _addressDal.GetAll();
        }

        public void TInsert(Adress entity)
        {
            _addressDal.Insert(entity);
        }

        public void TUpdate(Adress entity)
        {
            _addressDal.Update(entity);
        }
    }
}
