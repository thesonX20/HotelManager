namespace WindowsFormsApp1.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            BANGLUONGs = new HashSet<BANGLUONG>();
            PHIEUDATPHONGs = new HashSet<PHIEUDATPHONG>();
            PHIEUDENBUs = new HashSet<PHIEUDENBU>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(30)]
        public string TENNV { get; set; }

        public bool? PHAI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NAMSINH { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGLUONG> BANGLUONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDENBU> PHIEUDENBUs { get; set; }
    }
}
