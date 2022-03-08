using System.Collections.Generic;

namespace FinalProjectTest.Models
{
    public interface IRepository<T> where T : class
    {



        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        void Save();
    }
}
