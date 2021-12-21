using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050355.Models
{
    [Table("NhaCungCap355")]

    public class NhaCungCap355
    {
        [Key]
        [Display(Name = "ID Nhà Cung Cấp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Manhacungcap { get; set; }
        [Display(Name = "Tên Nhà Cung Cấp")]

        [StringLength(50)]

        public string Tennhacungcap { get; set; }
        public ICollection<HDDSanPham355> HDDSanPham355s { get; set; }
    }
}