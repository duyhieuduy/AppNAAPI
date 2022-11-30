using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Loaimon
    {
        public Loaimon()
        {
            Mons = new HashSet<Mon>();
        }

        public int Maloai { get; set; }
        public string? Tenloai { get; set; }

        public virtual ICollection<Mon> Mons { get; set; }
    }
}
