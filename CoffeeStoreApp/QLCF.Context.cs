﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeStoreApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_CAFEEntities : DbContext
    {
        public QL_CAFEEntities()
            : base("name=QL_CAFEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BAN> BANs { get; set; }
        public virtual DbSet<CALAMVIEC> CALAMVIECs { get; set; }
        public virtual DbSet<CHITIETHD> CHITIETHDs { get; set; }
        public virtual DbSet<CUNGCAP> CUNGCAPs { get; set; }
        public virtual DbSet<HANGHOA> HANGHOAs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUVUC> KHUVUCs { get; set; }
        public virtual DbSet<KIEMKE> KIEMKEs { get; set; }
        public virtual DbSet<LOAIHANGHOA> LOAIHANGHOAs { get; set; }
        public virtual DbSet<LOAIKHACHHANG> LOAIKHACHHANGs { get; set; }
        public virtual DbSet<NHACC> NHACCs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
    }
}