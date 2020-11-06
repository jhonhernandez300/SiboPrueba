using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sibo.Examen.Site
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["AdviserID"] != null)
            {
                labAdviserID.Text = Request.Params["AdviserID"];
            }
        }

               protected void butIngresarOBuscarCliente_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ManageClient.aspx?AdviserID=" + labAdviserID.Text);
        }
    }
}