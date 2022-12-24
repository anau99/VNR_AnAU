using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VNR_AnAU.Models
{
    public class KhoaHoc
    {
    
        [Key]
        public int Id { get; set; }
        public string ? TenKhoaHoc { get; set; }
    
    }
}
