using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Thongbao
    {
        public int IdTb { get; set; }
        public string Tendangnhap { get; set; } = null!;
        public string? Noidungtb { get; set; }

        public virtual Nguoidung TendangnhapNavigation { get; set; } = null!;
    }
}
