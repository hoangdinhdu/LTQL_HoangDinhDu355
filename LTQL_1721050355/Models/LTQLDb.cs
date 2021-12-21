using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050355.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }
        public virtual DbSet<NhaCungCap355> NhaCungCap355s { get; set; }
        public virtual DbSet<HDDSanPham355> HDDSanPham355s { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
