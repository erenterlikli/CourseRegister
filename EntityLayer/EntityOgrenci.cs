using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int OgrId;
        private string OgrNo;
        private string OgrAd;
        private string OgrSoyad;
        private string OgrMail;
        private string OgrSifre;
        private double OgrBakiye;

        public int OgrId1 { get => OgrId; set => OgrId = value; }
        public string OgrNo1 { get => OgrNo; set => OgrNo = value; }
        public string OgrAd1 { get => OgrAd; set => OgrAd = value; }
        public string OgrSoyad1 { get => OgrSoyad; set => OgrSoyad = value; }
        public string OgrMail1 { get => OgrMail; set => OgrMail = value; }
        public string OgrSifre1 { get => OgrSifre; set => OgrSifre = value; }
        public double OgrBakiye1 { get => OgrBakiye; set => OgrBakiye = value; }
    }
}
