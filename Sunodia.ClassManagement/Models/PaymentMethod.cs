//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sunodia.ClassManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentMethod()
        {
            this.EventTransactions = new HashSet<EventTransaction>();
            this.MiscTransactions = new HashSet<MiscTransaction>();
            this.MiscTransactions1 = new HashSet<MiscTransaction>();
        }
    
        public int Id { get; set; }
        public string PaymentMethod1 { get; set; }
        public decimal Percentage { get; set; }
        public decimal PlusFee { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventTransaction> EventTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiscTransaction> MiscTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiscTransaction> MiscTransactions1 { get; set; }
    }
}
