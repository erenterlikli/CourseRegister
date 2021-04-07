using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci p1)
        {
            if(p1.OgrNo1!=null && p1.OgrAd1!=null && p1.OgrSoyad1!=null && p1.OgrMail1!=null && p1.OgrSifre1!=null )
            {
                return DataAccessOgrenci.OgrenciEkle(p1);

            }
            return -1; //işlemi yapma.
        }

        public static List<EntityOgrenci> BLLListele()
        {
            return DataAccessOgrenci.OgrenciListesi();
        }

        public static bool BLLSil(int p2)
        {
            if(p2!=null)
            {
                return DataAccessOgrenci.OgrenciSil(p2);
            }

            return false;
        }

        public static List<EntityOgrenci> BLLDetay(int p)
        {
            return DataAccessOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBLL(EntityOgrenci p3)
        {
            if (p3.OgrAd1 != null && p3.OgrAd1 != "" && p3.OgrSoyad1!=null && p3.OgrSoyad1!="" && p3.OgrNo1!=null && p3.OgrNo1!="" && p3.OgrMail1!=null && p3.OgrMail1!="" && p3.OgrSifre1!=null && p3.OgrSifre1!="")
            {
                return DataAccessOgrenci.OgrenciGuncelle(p3);
               
            }
            return false;
        }
    }
}
