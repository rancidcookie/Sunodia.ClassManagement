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
    
    public partial class QBAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QBAccount()
        {
            this.CourseFormats = new HashSet<CourseFormat>();
            this.MiscTransactions = new HashSet<MiscTransaction>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public string QBAccount1 { get; set; }
        public bool IsCredit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseFormat> CourseFormats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiscTransaction> MiscTransactions { get; set; }
    }
}
