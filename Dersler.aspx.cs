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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDers> entders = BusinessLogicDers.BLLListe();
                DropDownList1.DataSource = BusinessLogicDers.BLLListe();
                DropDownList1.DataTextField = "DersAd1";
                DropDownList1.DataValueField = "DersId1";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuru ent = new EntityBasvuru();
            ent.OgrId1 = int.Parse(TextBox1.Text);
            ent.DersId1 = int.Parse(DropDownList1.SelectedValue.ToString());
            BusinessLogicDers.DersTalebiBLL(ent);
        }
    }
}