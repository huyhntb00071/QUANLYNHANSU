//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_NHANVIEN_PHUCAP
    {
        public Nullable<int> MANV { get; set; }
        public Nullable<int> IDPC { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<double> SOTIEN { get; set; }
        public int ID { get; set; }
    
        public virtual tb_NHANVIEN tb_NHANVIEN { get; set; }
        public virtual tb_PHUCCAP tb_PHUCCAP { get; set; }
    }
}