using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Nguoidungdb
    {
        public int IdNddb { get; set; }
        public int? Mamon { get; set; }
        public string? Tendangnhap { get; set; }

        public virtual Mon? MamonNavigation { get; set; }
        public virtual Nguoidung? TendangnhapNavigation { get; set; }
    }
}
