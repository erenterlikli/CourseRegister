using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.OgrNo1 = TxtOgrNo.Text;
            ent.OgrAd1 = TxtOgrAd.Text;
            ent.OgrSoyad1 = TxtOgrSoyad.Text;
            ent.OgrMail1 = TxtOgrMail.Text;
            ent.OgrSifre1 = TxtSifre.Text; 

            BusinessLogicOgrenci.OgrenciEkle(ent);

            Response.Write("<script>alert('Kaydınız Başarıyla Gerçekleştirildi!')</script>");
            TxtOgrNo.Text = "";
            TxtOgrAd.Text = "";
            TxtOgrSoyad.Text = "";
            TxtOgrMail.Text = "";
            TxtSifre.Text = "";
            
        }
    }
}