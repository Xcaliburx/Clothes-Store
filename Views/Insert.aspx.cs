using _2301854403_Benny_Kharisma.Factory;
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
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string txtprice = TxtPrice.Text;
            string desc = TxtDesc.Text;
            string type = TxtType.Text;
            int price = 0;

            String msg = "";
            bool check = true;

            if (name.Equals(""))
            {
                msg += "Name must be filled\n";
                check = false;
            }
            else if(name.Length < 5 || name.Length > 15)
            {
                msg += "Name length must be between 5 and 15 characters\n";
                check = false;
            }
            else if (!ClothesRepository.checkName(name))
            {
                msg += "Name must be unique\n";
                check = false;
            }

            if (type.Equals(""))
            {
                msg += "Type must be filled\n";
                check = false;
            }
            else if(!type.Equals("T-Shirt") && !type.Equals("Jacket") && !type.Equals("Sweater"))
            {
                msg += "Type must be between T-Shirt, Jacket, and Sweater\n";
                check = false;
            }

            if (desc.Equals("")) {
                msg += "Decription must be filled\n";
                check = false;
            }
            else if(desc.Length < 20)
            {
                msg += "Description length must be at least 20 characters\n";
                check = false;
            }

            if (txtprice.Equals(""))
            {
                msg += "Price must be filled\n";
                check = false;
            }
            else
            {
                price = int.Parse(txtprice);
                if (price <= 0){
                    msg += "Price must be more than 0\n";
                    check = false;
                }
            }

            if (check)
            {
                Cloth cloth = ClothFactory.createCloth(name, type, desc, price);
                ClothesRepository.insertClothes(cloth);
                msg += "Success Insert Cloth";
            }

            Lblmsg.Text = msg;
        }
    }
}