using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


namespace WebApplication1
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           int x = Convert.ToInt32(Request.QueryString["OgrId1"]); //hangi id değerine sahip isme tıklarsak onun id'sini yazdırsın.
           TxtId.Text = x.ToString();
           TxtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BusinessLogicOgrenci.BLLDetay(x);
                TxtOgrNo.Text = OgrList[0].OgrNo1.ToString();
                TxtOgrAd.Text = OgrList[0].OgrAd1.ToString();
                TxtOgrSoyad.Text = OgrList[0].OgrSoyad1.ToString();
                TxtOgrMail.Text = OgrList[0].OgrMail1.ToString();
                TxtSifre.Text = OgrList[0].OgrSifre1.ToString();

            }
            
        }

       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.OgrNo1 = TxtOgrNo.Text;
            ent.OgrAd1 = TxtOgrAd.Text;
            ent.OgrSoyad1 = TxtOgrSoyad.Text;
            ent.OgrMail1 = TxtOgrMail.Text;
            ent.OgrSifre1 = TxtSifre.Text;
            ent.OgrId1 = Convert.ToInt32(TxtId.Text);

            BusinessLogicOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}