using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWord.Data.Repositories
{
    public class BaseRepository<TContext>
    {
        protected DbContext Context { get; set; }
        protected DbContextTransaction ContextTransaction { get; set; }

        protected BaseRepository(DbContext context)
        {
            Context = context;
        }

        public void Store<T>(T entity) where T : class
        {
            Context.Entry(entity).State = Context.Entry(entity).State == EntityState.Detached ? EntityState.Added : EntityState.Modified;
            Commit();
        }

        public void Storing<T>(T entity) where T : class
        {
            Context.Entry(entity).State = Context.Entry(entity).State == EntityState.Detached ? EntityState.Added : EntityState.Modified;
        }

        public void Commit()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder exceptions = new StringBuilder();
                foreach (var e in ex.EntityValidationErrors)
                {
                    exceptions.Append($"Entity of type {e.Entry.Entity.GetType().Name} in state {e.Entry.State} has the following validation errors: ");

                    foreach (var ve in e.ValidationErrors)
                    {
                        exceptions.Append($"- Property: {ve.PropertyName}, Value: {e.Entry.CurrentValues.GetValue<object>(ve.PropertyName)}, Error: {ve.ErrorMessage}");
                    }
                }
            }
        }

        public void Delete<T>(T entity) where T : class
        {
            Context.Entry(entity).State = EntityState.Deleted;
            Commit();
        }

        public void Deleting<T>(T entity) where T : class
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public void BeginTransaction()
        {
            ContextTransaction = Context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
        }

        public void CommitTransaction()
        {
            ContextTransaction.Commit();
            ContextTransaction.Dispose();
        }

        public void Rollback()
        {
            ContextTransaction.Rollback();
        }
    }
}
