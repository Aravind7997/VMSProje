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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VSMSEntities : DbContext
    {
        public VSMSEntities()
            : base("name=VSMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BillInfo> BillInfoes { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMasters { get; set; }
        public virtual DbSet<ItemsInfo> ItemsInfoes { get; set; }
        public virtual DbSet<ServiceRecordInfo> ServiceRecordInfoes { get; set; }
        public virtual DbSet<ServiceRepInfo> ServiceRepInfoes { get; set; }
        public virtual DbSet<VehicleMaster> VehicleMasters { get; set; }
    }
}
