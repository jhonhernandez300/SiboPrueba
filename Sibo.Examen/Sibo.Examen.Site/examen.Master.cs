using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sibo.Examen.DAL.Model2;

namespace Sibo.Examen.Site
{
    public partial class examen : System.Web.UI.MasterPage
    {
        public Client masterClient { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
                Response.Redirect("default.aspx");
            else
            {
                Adviser eClient =(Adviser)Session["User"];
                labNombreDeUsuario.Text = eClient.Name + " " + eClient.LastName;
            }
        }

        protected void lnkSalir_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("default.aspx");
        }

        protected void butVerFacturas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Invoices.aspx");
        }
    }
}