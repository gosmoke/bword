using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWord.Data.Repositories
{
    public class BWordDataRepository : BaseRepository<BWordEntities>, IBWordDataRepository
    {
        public BWordDataRepository(BWordEntities context) : base(context)
        {
            Context.Configuration.LazyLoadingEnabled = true;
        }

        public void Store<T>(T entity) where T : class
        {
            base.Store(entity);
        }

        public void Storing<T>(T entity) where T : class
        {
            base.Storing(entity);
        }

        public IEnumerable<BudgetCategory> GetBudgetCategories()
        {
            return ((BWordEntities)Context).BudgetCategories.AsNoTracking();
        }

        public IEnumerable<Budget> GetBudgets()
        {
            return ((BWordEntities)Context).Budgets;
        }

        public IEnumerable<Category> GetCategories()
        {
            return ((BWordEntities)Context).Categories.AsNoTracking();
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return ((BWordEntities)Context).Transactions;
        }

        public IEnumerable<TransactionType> GetTransactionTypes()
        {
            return ((BWordEntities)Context).TransactionTypes.AsNoTracking();
        }
    }
}
