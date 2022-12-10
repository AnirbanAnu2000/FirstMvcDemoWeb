using FirstDemo.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Base.Data
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll(T tEntity); //IList GetAll(Course course); 
        public T GetById(int entityId);
        void Insert(T tEntity);
        //void Update(T tEntity);
        //void Delete(int entityId);
        void Save();
    }
}