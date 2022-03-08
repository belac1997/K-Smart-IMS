using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectTest.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected Context context { get; set; }
        private DbSet<T> dbset { get; set; }
        public Repository(Context ctx) {
            context = ctx;
            dbset = context.Set<T>();
        }

        public virtual void Insert(T entity) => dbset.Add(entity);
        public virtual void Update(T entity) => dbset.Update(entity);
        public virtual void Delete(T entity) => dbset.Remove(entity);
        public virtual void Save() => context.SaveChanges();

    }
}
