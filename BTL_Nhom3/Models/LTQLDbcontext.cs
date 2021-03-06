using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTL_Nhom3.Models
{
    public partial class LTQLDbcontext : DbContext
    {
        public LTQLDbcontext()
            : base("name=LTQLDbcontext")
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
       // public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
