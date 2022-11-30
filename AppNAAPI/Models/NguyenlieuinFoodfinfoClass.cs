using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppNAAPI.Models
{
    public partial class NguyenlieuinFoodfinfoClass
    {
        [Key]
        public String? tennguyenlieu { get; set; }
        public String? anhnguyenlieu { get; set; }
    }
}
