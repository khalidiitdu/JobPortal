﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BdJobsOnline.BdJobsDatabase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BdJobsEntities : DbContext
    {
        public BdJobsEntities()
            : base("name=BdJobsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobDescription> JobDescriptions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
