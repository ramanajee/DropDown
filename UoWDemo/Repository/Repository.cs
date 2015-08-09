using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UoWDemo.DAL;

namespace UoWDemo.Repository
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private InformationContext context;
        private DbSet<T> dbSet;
        public Repository(InformationContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        public virtual T Add(T entity)
        {
            dbSet.Add(entity);
            return entity;
        }
        public virtual T FindById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual T Edit(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
        public virtual void DeleteById(int id)
        {
            var entity = dbSet.Find(id);
            Delete(entity);
        }

        public virtual void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }
    }
}
