using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.DAL.Repositories.Infrastructure
{
    internal interface IRepository<T> : IDisposable where T : class
    {
        DrMinaClinicEntities Context { get; }
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
        IQueryable<T> GetAll();
        T GetById(int id);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
    }

    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        #region Properties

        public DrMinaClinicEntities Context => DrMinaClinicContext.Instance;

        private DbSet<T> _dbSet;
        public DbSet<T> DbSet => _dbSet ?? (_dbSet = Context.Set<T>());

        #endregion

        #region Methods

        public void Add(T entity)
        {
            DbSet.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
            Save();
        }

        public void Update(T entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || Context == null) return;
            Context?.Dispose();
        }

        #endregion
    }
}