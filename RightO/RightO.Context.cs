﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RightO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RightOEntities1 : DbContext
    {
        public RightOEntities1()
            : base("name=RightOEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoryMaster> CategoryMasters { get; set; }
        public virtual DbSet<CustomerUserMaster> CustomerUserMasters { get; set; }
        public virtual DbSet<FeedBackHistory> FeedBackHistories { get; set; }
        public virtual DbSet<ProUserCategoryMapping> ProUserCategoryMappings { get; set; }
        public virtual DbSet<ProUserMaster> ProUserMasters { get; set; }
        public virtual DbSet<ProUserWorkLocationMapping> ProUserWorkLocationMappings { get; set; }
        public virtual DbSet<ProUserWorkTimingsMapping> ProUserWorkTimingsMappings { get; set; }
        public virtual DbSet<QuestionMaster> QuestionMasters { get; set; }
        public virtual DbSet<SubCategoryMaster> SubCategoryMasters { get; set; }
        public virtual DbSet<TestimonialHistory> TestimonialHistories { get; set; }
        public virtual DbSet<UserServiceInfo> UserServiceInfoes { get; set; }
        public virtual DbSet<UserServicesUsedHistory> UserServicesUsedHistories { get; set; }
        public virtual DbSet<WorkLocationsMaster> WorkLocationsMasters { get; set; }
        public virtual DbSet<WorkTimingsMaster> WorkTimingsMasters { get; set; }
    }
}