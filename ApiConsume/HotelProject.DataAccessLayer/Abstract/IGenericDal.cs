using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t); //ekleme
        void Delete(T t);//silme
        void Update(T t);//güncelleme   
        List<T> GetList();//listeleme
        T GetByID(int id);// ıdye göre bulma
    }
}
