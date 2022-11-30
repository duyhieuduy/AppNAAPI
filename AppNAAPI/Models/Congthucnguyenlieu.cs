using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Congthucnguyenlieu
    {
        public int Mamon { get; set; }
        public int Manguyenlieu { get; set; }
        public string? Khoiluong { get; set; }

        public virtual Mon MamonNavigation { get; set; } = null!;
        public virtual Nguyenlieu ManguyenlieuNavigation { get; set; } = null!;
    }
}
