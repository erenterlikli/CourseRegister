using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DataAccessOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre1) //ekleme komutu için.
        {
            SqlCommand komutekle = new SqlCommand("insert into Ogrenci(OgrNo,OgrAd,OgrSoyad,OgrMail,OgrSifre,OgrBakiye) values(@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.baglan);

            if(komutekle.Connection.State!= ConnectionState.Open) //bağlantı açık değilse
            {
                komutekle.Connection.Open();
            }

            komutekle.Parameters.AddWithValue("@p1", parametre1.OgrNo1);
            komutekle.Parameters.AddWithValue("@p2", parametre1.OgrAd1);
            komutekle.Parameters.AddWithValue("@p3", parametre1.OgrSoyad1);
            komutekle.Parameters.AddWithValue("@p4", parametre1.OgrMail1);
            komutekle.Parameters.AddWithValue("@p5", parametre1.OgrSifre1);
            komutekle.Parameters.AddWithValue("@p6", parametre1.OgrBakiye1);

            return komutekle.ExecuteNonQuery();

        }

        public static List<EntityOgrenci> OgrenciListesi() //listeleme için.
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komutliste = new SqlCommand("select *from Ogrenci", Baglanti.baglan);

            if (komutliste.Connection.State != ConnectionState.Open) //bağlantı açık değilse
            {
                komutliste.Connection.Open();
            }

            SqlDataReader dr = komutliste.ExecuteReader();
            while(dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OgrId1 = Convert.ToInt32(dr["OgrId"].ToString());
                ent.OgrNo1 = dr["OgrNo"].ToString();
                ent.OgrAd1 = dr["OgrAd"].ToString();
                ent.OgrSoyad1 = dr["OgrSoyad"].ToString();
                ent.OgrMail1 = dr["OgrMail"].ToString();
                ent.OgrSifre1 = dr["OgrSifre"].ToString();
                ent.OgrBakiye1 = Convert.ToDouble(dr["OgrBakiye"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre2) //öğrenci silme için.
        {
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where OgrId=@d1", Baglanti.baglan);

            if (komutsil.Connection.State != ConnectionState.Open) //bağlantı açık değilse
            {
                komutsil.Connection.Open();
            }

            komutsil.Parameters.AddWithValue("@d1", parametre2);
            return komutsil.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id) //listeleme için.
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komutdetay = new SqlCommand("select *from Ogrenci where OgrId=@p1", Baglanti.baglan);

            if (komutdetay.Connection.State != ConnectionState.Open) //bağlantı açık değilse
            {
                komutdetay.Connection.Open();
            }

            komutdetay.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = komutdetay.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OgrId1 = Convert.ToInt32(dr["OgrId"].ToString());
                ent.OgrNo1 = dr["OgrNo"].ToString();
                ent.OgrAd1 = dr["OgrAd"].ToString();
                ent.OgrSoyad1 = dr["OgrSoyad"].ToString();
                ent.OgrMail1 = dr["OgrMail"].ToString();
                ent.OgrSifre1 = dr["OgrSifre"].ToString();

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Ogrenci set OgrNo=@p1, OgrAd=@p2, OgrSoyad=@p3, OgrMail=@p4, OgrSifre=@p5 where OgrId=@p6", Baglanti.baglan);

            if (komutguncelle.Connection.State != ConnectionState.Open) //bağlantı açık değilse
            {
                komutguncelle.Connection.Open();
            }

            komutguncelle.Parameters.AddWithValue("@p1", deger.OgrNo1);
            komutguncelle.Parameters.AddWithValue("@p2", deger.OgrAd1);
            komutguncelle.Parameters.AddWithValue("@p3", deger.OgrSoyad1);
            komutguncelle.Parameters.AddWithValue("@p4", deger.OgrMail1);
            komutguncelle.Parameters.AddWithValue("@p5", deger.OgrSifre1);
            komutguncelle.Parameters.AddWithValue("@p6", deger.OgrId1);

            return komutguncelle.ExecuteNonQuery() > 0;
        }

    }
}
