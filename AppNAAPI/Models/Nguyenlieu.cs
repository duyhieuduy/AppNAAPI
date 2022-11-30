using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Nguyenlieu
    {
        public Nguyenlieu()
        {
            Congthucnguyenlieus = new HashSet<Congthucnguyenlieu>();
        }

        public int Manguyenlieu { get; set; }
        public string? Tennguyenlieu { get; set; }
        public string? Anhnguyenlieu { get; set; }

        public virtual ICollection<Congthucnguyenlieu> Congthucnguyenlieus { get; set; }
    }
}
