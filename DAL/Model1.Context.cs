﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Connection : DbContext
    {
        public Connection()
            : base("name=Connection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Admin_account> Admin_account { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Class_student> Class_student { get; set; }
        public virtual DbSet<Class_weekday> Class_weekday { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_account> Student_account { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Teacher_account> Teacher_account { get; set; }
        public virtual DbSet<Weekday> Weekdays { get; set; }
    }
}
