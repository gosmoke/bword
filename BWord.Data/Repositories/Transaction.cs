//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BWord.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public int BudgetCategoryId { get; set; }
        public int TransactionTypeId { get; set; }
        public Nullable<System.DateTime> EnteredOn { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Notes { get; set; }
    
        public virtual BudgetCategory BudgetCategory { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}
