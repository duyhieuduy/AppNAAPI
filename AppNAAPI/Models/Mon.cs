using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Mon
    {
        public Mon()
        {
            Anhmonans = new HashSet<Anhmonan>();
            Binhluans = new HashSet<Binhluan>();
            Congthucnguyenlieus = new HashSet<Congthucnguyenlieu>();
            Nguoidungdbs = new HashSet<Nguoidungdb>();
            Nguoidungsaves = new HashSet<Nguoidungsave>();
        }

        public int Mamon { get; set; }
        public int? Maloai { get; set; }
        public string? Tenmon { get; set; }
        public string? Congthuclam { get; set; }
        public string? Tgnau { get; set; }
        public string? Dokho { get; set; }
        public string? Anhmonlvo { get; set; }
        public string? Cachlam { get; set; }

        public virtual Loaimon? MaloaiNavigation { get; set; }
        public virtual ICollection<Anhmonan> Anhmonans { get; set; }
        public virtual ICollection<Binhluan> Binhluans { get; set; }
        public virtual ICollection<Congthucnguyenlieu> Congthucnguyenlieus { get; set; }
        public virtual ICollection<Nguoidungdb> Nguoidungdbs { get; set; }
        public virtual ICollection<Nguoidungsave> Nguoidungsaves { get; set; }
    }
}
