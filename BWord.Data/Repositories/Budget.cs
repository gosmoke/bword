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
    
    public partial class Budget
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Budget()
        {
            this.BudgetCategories = new HashSet<BudgetCategory>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid UserId { get; set; }
        public string Name { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetCategory> BudgetCategories { get; set; }
    }
}
