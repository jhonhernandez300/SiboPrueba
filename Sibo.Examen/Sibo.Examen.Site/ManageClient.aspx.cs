using Sibo.Examen.BLL;
using Sibo.Examen.DAL.Model2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sibo.Examen.Site
{
    public partial class ManageClient2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["AdviserID"] != null)
            {
                labAdviserID.Text = Request.Params["AdviserID"];
            }
            else
            {
                butConsultar.Enabled = false;
                MessageBox("", "El Id del Adviser no puede ser nulo, por favor ingrese de nuevo");
                Response.Redirect("default.aspx");
            }

            butIngresarCliente.Enabled = false;
            butIngresarClienteConServicio.Enabled = false;
            butIngresarCompra.Enabled = false;
            butIngresarCompraConProcedimiento.Enabled = false;
        }

        protected void Consultar(object sender, EventArgs e)
        {            
            //Service service = new Service();
            ClientBLL clientBll = new ClientBLL();
            var clients = clientBll.Get();

            if (clients.Any()) 
            {
                string cedula = texCedula.Text.Trim();
                var encontrado = clients.FirstOrDefault(x => x.Identification == cedula);

                if (encontrado != null)
                {
                    texNombres.Text = encontrado.Name;
                    texApellidos.Text = encontrado.LastName;
                    labClientID.Text = encontrado.ClientID.ToString();
                    butIngresarCompra.Enabled = true;
                    butIngresarCompraConProcedimiento.Enabled = true;
                }
                else 
                {
                    MessageBox("No Encontrado", "Esta cédula no está en el sistema, por favor, regístrela");
                    butIngresarCliente.Enabled = true;
                    butIngresarClienteConServicio.Enabled = true;
                }

            }

        }

        private void MessageBox(string Title, string Message)
        {            
            labMessage.Text = "<script>alert('"+ Message + "')</script>";

        }

        protected void butIngresarCompra_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertInvoice.aspx?ClientID=" + labClientID.Text + "&AdvisorID=" + labAdviserID.Text);
        }

        protected void butIngresar_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Identification = texCedula.Text;
            client.Name = texNombres.Text;
            client.LastName = texApellidos.Text;

            ClientBLL clientBLL = new ClientBLL();
            var insertedClient = clientBLL.Post(client);
            MessageBox("Nuevo cliente", "Registro ingresado");
            labClientID.Text = insertedClient.ClientID.ToString();
            butIngresarCompra.Enabled = true;
            butIngresarCompraConProcedimiento.Enabled = true;
        }

        protected void butIngresarCompraConProcedimiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertInvoiceWithProcedure.aspx?ClientID=" + labClientID.Text + "&AdvisorID=" + labAdviserID.Text);
        }

        protected void butConsultarConServicio_Click(object sender, EventArgs e)
        {
            //var clients = Service.Get();            

            /*if (clients.Any())
            {
                string cedula = texCedula.Text.Trim();
                var encontrado = clients.FirstOrDefault(x => x.Identification == cedula);

                if (encontrado != null)
                {
                    texNombres.Text = encontrado.Name;
                    texApellidos.Text = encontrado.LastName;
                    labClientID.Text = encontrado.ClientID.ToString();
                    butIngresarCompra.Enabled = true;
                }
                else
                {
                    MessageBox("No Encontrado", "Esta cédula no está en el sistema, por favor, regístrela");
                    butIngresarCliente.Enabled = true;
                }
            }*/
        }

        protected void butIngresarClienteConServicio_Click(object sender, EventArgs e)
        {
            /*var inserted = ServiceReference.Post(texCedula.Text, texNombres.Text, texApellidos.Text);

            if (inserted)
            {
                MessageBox("Nuevo cliente", "Registro ingresado");
                labClientID.Text = inserted.ClientID.ToString();
                butIngresarCompra.Enabled = true;
                butIngresarCompraConProcedimiento.Enabled = true;
            }*/
        }
    }
}