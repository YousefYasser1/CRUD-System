using Demo.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBaseRepository<T> where T: class
    {
        T GetById(int id); 
        List<T> GetAll();
        void Create(T entity);
        void Edit(T entity);
        void Delete(T entity);
    }
}
