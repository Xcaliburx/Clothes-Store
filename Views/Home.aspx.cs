using _2301854403_Benny_Kharisma.Model;
using _2301854403_Benny_Kharisma.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2301854403_Benny_Kharisma.Views
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cloth> clothes = ClothesRepository.getAllClothes();
            Repeater.DataSource = clothes;
            Repeater.DataBind();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);
            Response.Redirect("./Update.aspx?id=" + id);
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);
            ClothesRepository.deleteClothes(id);
            Response.Redirect("./Home.aspx");
        }
    }
}