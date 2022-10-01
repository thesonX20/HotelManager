namespace WindowsFormsApp1.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGLUONG")]
    public partial class BANGLUONG
    {
        [Key]
        [StringLength(10)]
        public string MALUONG { get; set; }

        [StringLength(15)]
        public string MUCLUONG { get; set; }

        public int? TIENLUONG { get; set; }

        public int? PHUCAP { get; set; }

        [Required]
        [StringLength(10)]
        public string MANV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
