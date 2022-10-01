namespace WindowsFormsApp1.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDATPHONG")]
    public partial class PHIEUDATPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDATPHONG()
        {
            PHIEUDENBUs = new HashSet<PHIEUDENBU>();
        }

        [Key]
        [StringLength(10)]
        public string MAPDP { get; set; }

        public int? TIENCOC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTRADP { get; set; }

        public int? TONGTIENDP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYNHANPHONG { get; set; }

        [Required]
        [StringLength(10)]
        public string MANV { get; set; }

        [Required]
        [StringLength(10)]
        public string MAKH { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDENBU> PHIEUDENBUs { get; set; }
    }
}
