using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course.Models
{
    public class ExamModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        [AllowHtml]
        public string Icerik { get; set; }
        public string KonuUrl { get; set; }
        public DateTime Tarih { get; set; }

        public List<ArticlesModel> Konular { get; set; }

        public string Cevap1 { get; set; }
        public string Cevap2 { get; set; }
        public string Cevap3 { get; set; }
        public string Cevap4 { get; set; }


        public string Soru1 { get; set; }
        public string Soru2 { get; set; }
        public string Soru3 { get; set; }
        public string Soru4 { get; set; }
        public string Cevap1D { get; set; }
        public string Cevap2D { get; set; }
        public string Cevap3D { get; set; }
        public string Cevap4D { get; set; }
        public string Cevap1A { get; set; }
        public string Cevap2A { get; set; }
        public string Cevap3A { get; set; }
        public string Cevap4A { get; set; }
        public string Cevap1B { get; set; }
        public string Cevap2B { get; set; }
        public string Cevap3B { get; set; }
        public string Cevap4B { get; set; }
        public string Cevap1C { get; set; }
        public string Cevap2C { get; set; }
        public string Cevap3C { get; set; }
        public string Cevap4C { get; set; }
    }
}