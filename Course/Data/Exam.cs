namespace Course.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exam")]
    public partial class Exam
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Soru1 { get; set; }

        [StringLength(50)]
        public string Soru2 { get; set; }

        [StringLength(50)]
        public string Soru3 { get; set; }

        [StringLength(50)]
        public string Soru4 { get; set; }

        [StringLength(50)]
        public string Cevap1 { get; set; }

        [StringLength(50)]
        public string Cevap2 { get; set; }

        [StringLength(50)]
        public string Cevap3 { get; set; }

        [StringLength(50)]
        public string Cevap4 { get; set; }

        [StringLength(50)]
        public string Cevap1A { get; set; }

        [StringLength(50)]
        public string Cevap2A { get; set; }

        [StringLength(50)]
        public string Cevap3A { get; set; }

        [StringLength(50)]
        public string Cevap4A { get; set; }

        [StringLength(50)]
        public string Cevap1B { get; set; }

        [StringLength(50)]
        public string Cevap2B { get; set; }

        [StringLength(50)]
        public string Cevap3B { get; set; }

        [StringLength(50)]
        public string Cevap4B { get; set; }

        [StringLength(50)]
        public string Cevap1C { get; set; }

        [StringLength(50)]
        public string Cevap2C { get; set; }

        [StringLength(50)]
        public string Cevap3C { get; set; }

        [StringLength(50)]
        public string Cevap4C { get; set; }

        [StringLength(50)]
        public string Cevap1D { get; set; }

        [StringLength(50)]
        public string Cevap2D { get; set; }

        [StringLength(50)]
        public string Cevap3D { get; set; }

        [StringLength(50)]
        public string Cevap4D { get; set; }

        public string Baslik { get; set; }

        public string Icerik { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }
    }
}
