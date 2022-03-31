//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class VehicleMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleMaster()
        {
            this.ServiceRecordInfoes = new HashSet<ServiceRecordInfo>();
        }
    [DataMember]
        public int ModelNo { get; set; }
        [DataMember]
        public string ModelName { get; set; }
        [DataMember]
        public Nullable<int> ModelYear { get; set; }
        [DataMember]
        public string VehicleType { get; set; }
        [DataMember]
        public Nullable<System.DateTime> SoldDate { get; set; }
        [DataMember]
        public Nullable<int> ServiceSchedule { get; set; }
        [DataMember]
        public Nullable<int> CustId { get; set; }
    
        public virtual CustomerMaster CustomerMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRecordInfo> ServiceRecordInfoes { get; set; }
    }
}
