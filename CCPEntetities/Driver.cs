//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCPEntetities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.OwnersInformations = new HashSet<OwnersInformation>();
        }
    
        public string DriversId { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public System.DateTime TimeIn { get; set; }
        public Nullable<int> In { get; set; }
        public Nullable<int> Out { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OwnersInformation> OwnersInformations { get; set; }
    }
}