﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataFac
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bookdbEntities : DbContext
    {
        public bookdbEntities()
            : base("name=bookdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<S_Admin> S_Admin { get; set; }
        public virtual DbSet<S_Person> S_Person { get; set; }
        public virtual DbSet<S_Power> S_Power { get; set; }
        public virtual DbSet<S_Book> S_Book { get; set; }
        public virtual DbSet<S_BookType> S_BookType { get; set; }
    }
}
