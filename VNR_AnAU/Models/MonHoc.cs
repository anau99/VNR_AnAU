using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNR_AnAU.Models
{
    public class MonHoc
    {
        [Key]
        public int Id { get; set; }
        public string? TenMonHoc { get; set; }
        public string ? MoTa { get; set; }
        [ForeignKey("KhoaHocId")]
        public int KhoaHocId { get; set; }

    }
}
