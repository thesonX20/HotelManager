namespace WindowsFormsApp1.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            PHIEUDENBUs = new HashSet<PHIEUDENBU>();
            TIENNGHIs = new HashSet<TIENNGHI>();
        }

        [Key]
        [StringLength(10)]
        public string MAPHONG { get; set; }

        [StringLength(30)]
        public string HIENTRANG { get; set; }


        //[StringLength(10)]
        //public string TANG { get; set; }

        //[StringLength(20)]    
        public int? DIENTICH { get; set; }

        [Required]
        [StringLength(10)]
        public string MALP { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDENBU> PHIEUDENBUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIENNGHI> TIENNGHIs { get; set; }
    }
}
