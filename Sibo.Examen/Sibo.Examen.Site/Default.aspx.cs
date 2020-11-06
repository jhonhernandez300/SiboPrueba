using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Sibo.Examen.DAL.Model;
using Sibo.Examen.DAL.Model2;
using Sibo.Examen.BLL;

namespace Sibo.Examen.Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //important when use messages
            ltScript.Text = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string strUser = txtUser.Text.Trim();
            string strPassword = txtPassword.Text.Trim();
            AdviserBLL oAdviser = new AdviserBLL();
            Adviser eAdviser= oAdviser.Authenticate(strUser, strPassword);

            if (eAdviser != null)
            {
                Session["User"] = eAdviser;                                
                Response.Redirect("home.aspx?AdviserID="+ eAdviser.AdviserID);
            }
            else
            {
                MessageBox("Usuario no autenticado", "Los datos ingresados son incorrectos");
            }
        }

        private void MessageBox(string Title, string Message)
        {
            ltScript.Text = "<script>Message('" + Title + "','" + Message + "')</script>";
        }
    }
}