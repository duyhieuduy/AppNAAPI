using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Nguoidungsave
    {
        public int IdNds { get; set; }
        public int? Mamon { get; set; }
        public string? Tendangnhap { get; set; }
        public int? Trangthai { get; set; }

        public virtual Mon? MamonNavigation { get; set; }
        public virtual Nguoidung? TendangnhapNavigation { get; set; }
    }
}
