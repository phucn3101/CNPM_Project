//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBGOODS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class bill_import
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bill_import()
        {
            this.product_billimport = new HashSet<product_billimport>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> datecreate { get; set; }
        public string companyname { get; set; }
        public Nullable<int> totalprice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product_billimport> product_billimport { get; set; }
    }
}
