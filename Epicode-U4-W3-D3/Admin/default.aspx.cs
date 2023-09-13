using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_U4_W3_D3
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PizzeSelezionate"] == null)
                Session["PizzeSelezionate"] = new List<Pizza>();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect(FormsAuthentication.LoginUrl);
        }

        protected void Aggiungi_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza(Pizze.SelectedItem.Text, double.Parse(Pizze.SelectedValue));
            foreach(ListItem ingredeiente in Ingredienti.Items)
                if (ingredeiente.Selected)
                    pizza.addIngrediente(new Ingrediente(ingredeiente.Text, double.Parse(ingredeiente.Value)));
            
            //Aggiungo la pizza
            List<Pizza> pizze = (List<Pizza>)Session["PizzeSelezionate"];
            pizze.Add(pizza);
            Session["PizzeSelezionate"] = pizze;
        }

        protected void Completa_Click(object sender, EventArgs e)
        {
            double totale = 0;
            foreach (Pizza pizza in (List<Pizza>)Session["PizzeSelezionate"])
            {
                Totale.InnerHtml += pizza.stampaPizza();
                totale += pizza.Totale;
            }
            Totale.InnerHtml += $"Conto finale: {totale}€";
            Session["PizzeSelezionate"] = new List<Pizza>();
        }
    }
}