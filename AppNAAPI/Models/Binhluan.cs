using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Binhluan
    {
        public int IdBl { get; set; }
        public int? Mamon { get; set; }
        public string? Tendangnhap { get; set; }
        public string? Noidungbl { get; set; }

        public virtual Mon? MamonNavigation { get; set; }
        public virtual Nguoidung? TendangnhapNavigation { get; set; }
    }
}
