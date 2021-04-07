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
    public class DataAccessDers
    {
        public static List<EntityDers> DersListesi() //listeleme için.
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komutliste = new SqlCommand("select *from Ders", Baglanti.baglan);

            if (komutliste.Connection.State != ConnectionState.Open) //bağlantı açık değilse
            {
                komutliste.Connection.Open();
            }

            SqlDataReader dr = komutliste.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DersId1 = Convert.ToInt32(dr["DersId"].ToString());
                ent.DersAd1 = dr["DersAd"].ToString();
                ent.DersMinKont1 = Convert.ToInt32(dr["DersMinKont"].ToString());
                ent.DersMaksKont1 = Convert.ToInt32(dr["DersMaksKont"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int DersTalebi(EntityBasvuru p)
        {
            SqlCommand komut = new SqlCommand("insert into Basvuru(OgrId,DersId) values(@p1,@p2)", Baglanti.baglan);
            komut.Parameters.AddWithValue("@p1", p.OgrId1);
            komut.Parameters.AddWithValue("@p2", p.DersId1);

            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            return komut.ExecuteNonQuery();
        }
    }
}