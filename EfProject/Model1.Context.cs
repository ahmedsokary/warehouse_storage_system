//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EfProjectEntities1 : DbContext
    {
        public EfProjectEntities1()
            : base("name=EfProjectEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientPermission> ClientPermissions { get; set; }
        public virtual DbSet<ClientPermissionDetail> ClientPermissionDetails { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<MoveProduct> MoveProducts { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<ProductMeasure> ProductMeasures { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<StoredProduct> StoredProducts { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<SupplyPermision> SupplyPermisions { get; set; }
        public virtual DbSet<SupplyPermissionDetail> SupplyPermissionDetails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
