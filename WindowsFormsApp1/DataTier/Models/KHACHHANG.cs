namespace WindowsFormsApp1.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            PHIEUDATPHONGs = new HashSet<PHIEUDATPHONG>();
        }

        [Key]
        [StringLength(10)]
        public string MAKH { get; set; }

        [StringLength(30)]
        public string TENKH { get; set; }

        [StringLength(11)]
        public string SODT { get; set; }

        [StringLength(15)]
        public string CCCD { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(10)]
        public string MAPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
