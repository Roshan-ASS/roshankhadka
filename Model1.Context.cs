﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace roshankhadka
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities5 : DbContext
    {
        public Entities5()
            : base("name=Entities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<catageory> catageories { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<product_img> product_img { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
