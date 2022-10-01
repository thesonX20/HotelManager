namespace WindowsFormsApp1.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [StringLength(10)]
        public string MAHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYLAP { get; set; }

        public int? TONGTIEN { get; set; }

        [Required]
        [StringLength(10)]
        public string MADV { get; set; }

        public virtual DICHVU DICHVU { get; set; }
    }
}
