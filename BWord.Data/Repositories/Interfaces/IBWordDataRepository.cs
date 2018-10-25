using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWord.Data.Repositories
{
    public interface IBWordDataRepository
    {
        IEnumerable<Budget> GetBudgets();
        IEnumerable<BudgetCategory> GetBudgetCategories();
        IEnumerable<Category> GetCategories();
        IEnumerable<Transaction> GetTransactions();
        IEnumerable<TransactionType> GetTransactionTypes();
    }
}
