﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbStrahkomp : DbContext
    {
        public dbStrahkomp()
            : base("name=dbStrahkomp")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SK_dogovor> SK_dogovor { get; set; }
        public virtual DbSet<SK_filial_kompanii> SK_filial_kompanii { get; set; }
        public virtual DbSet<SK_Klient> SK_Klient { get; set; }
        public virtual DbSet<SK_strahovaya_kompania> SK_strahovaya_kompania { get; set; }
        public virtual DbSet<SK_vid_dogovora> SK_vid_dogovora { get; set; }
    }
}
