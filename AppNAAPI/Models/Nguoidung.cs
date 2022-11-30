using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Nguoidung
    {
        public Nguoidung()
        {
            Binhluans = new HashSet<Binhluan>();
            Nguoidungdbs = new HashSet<Nguoidungdb>();
            Nguoidungsaves = new HashSet<Nguoidungsave>();
            Thongbaos = new HashSet<Thongbao>();
        }

        public string Tendangnhap { get; set; } = null!;
        public string? Matkhau { get; set; }
        public int? Sdt { get; set; }
        public string? Email { get; set; }
        public string? Diachi { get; set; }
        public int? Tuoi { get; set; }

        public virtual ICollection<Binhluan> Binhluans { get; set; }
        public virtual ICollection<Nguoidungdb> Nguoidungdbs { get; set; }
        public virtual ICollection<Nguoidungsave> Nguoidungsaves { get; set; }
        public virtual ICollection<Thongbao> Thongbaos { get; set; }
    }
}
