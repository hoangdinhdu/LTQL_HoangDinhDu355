using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050355.Models
{
    [Table("HDDSanPham355")]
    public class HDDSanPham355
    {
        [Key]
        [Display(Name = "ID Sản Phẩm")]
        [StringLength(20)]
        public string Masanpham { get; set; }
        [Display(Name = "Tên Sản Phẩm")]

        [StringLength(50)]

        public string TenSanPham { get; set; }
        [Display(Name = "Mã Nhà cung cấp")]
        public int Manhacungcap { get; set; }
        [ForeignKey("Manhacungcap")]
        public virtual NhaCungCap355 NhaCungCap355 { get; set; }
    }
}