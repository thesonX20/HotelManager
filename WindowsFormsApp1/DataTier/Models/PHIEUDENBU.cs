namespace WindowsFormsApp1.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDENBU")]
    public partial class PHIEUDENBU
    {
        [Key]
        [StringLength(10)]
        public string MAPDB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDB { get; set; }

        [StringLength(50)]
        public string LYDODB { get; set; }

        public int? THANHTIEN { get; set; }

        [Required]
        [StringLength(10)]
        public string MAPHONG { get; set; }

        [Required]
        [StringLength(10)]
        public string MAPDP { get; set; }

        [Required]
        [StringLength(10)]
        public string MANV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
