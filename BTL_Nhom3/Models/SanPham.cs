using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_Nhom3.Models
{
    [Table("SanPhams")]
    public class SanPham
    {
        [Key]
        public string IDSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string Status { get; set; }
    }
}