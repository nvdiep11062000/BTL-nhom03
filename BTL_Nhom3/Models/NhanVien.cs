using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_Nhom3.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string IDNhanVien { get; set; }
        public string NameNhanVien { get; set; }
        public string Address { get; set; }
    }
}