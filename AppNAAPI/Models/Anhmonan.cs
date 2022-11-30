using System;
using System.Collections.Generic;

namespace AppNAAPI.Models
{
    public partial class Anhmonan
    {
        public int IdAma { get; set; }
        public int? Mamon { get; set; }
        public string? Anhmon { get; set; }

        public virtual Mon? MamonNavigation { get; set; }
    }
}
