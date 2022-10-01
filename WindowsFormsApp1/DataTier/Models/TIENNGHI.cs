namespace WindowsFormsApp1.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TIENNGHI")]
    public partial class TIENNGHI
    {
        [Key]
        [StringLength(10)]
        public string MATN { get; set; }

        [StringLength(30)]
        public string TENTN { get; set; }

        public int? SOLUONG { get; set; }

        [StringLength(30)]
        public string CHUTHICH { get; set; }

        [Required]
        [StringLength(10)]
        public string MAPHONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
