using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppNAAPI.Models
{
    public partial class Foodinfo
    {
        [Key]
        public String? tenmon { get; set; }
        public String? dokho { get; set; }
        public String? tgnau { get; set; }
        public String? anhmonlvo { get; set; }
        public String? tenloai { get; set; }


    }
}
