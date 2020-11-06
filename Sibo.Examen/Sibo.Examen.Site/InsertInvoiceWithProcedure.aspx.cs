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
    public partial class InsertInvoiceWithProcedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["ClientID"] != null && Request.Params["AdvisorID"] != null)
            {
                labCliente.Text = Request.Params["ClientID"];
                labAdvisorID.Text = Request.Params["AdvisorID"];

            }
            else
            {
                butAgregarProducto.Enabled = false;
                butBuscar.Enabled = false;
                MessageBox("", "El Id del cliente o del Advisor no pueden ser nulos, ingrese nuevamente");
                Response.Redirect("Default.aspx");
            }

            butIngresarVenta.Enabled = false;
        }

        protected void butBuscar2_Click(object sender, EventArgs e)
        {
            ProductBLL productBll = new BLL.ProductBLL();
            var encontrado = productBll.Get(Convert.ToInt32(texReferencia.Text));

            if (encontrado != null)
            {
                texNombre.Text = encontrado.Name;
                texValor.Text = string.Format("{0:N0}", encontrado.Price);
                texCantidadDisponible.Text = encontrado.Quantity.ToString();
                texDescuento.Text = string.Format("{0:N2}", encontrado.PercentDiscount);
                labProductID.Text = encontrado.ProductID.ToString();
            }
        }

        protected void butAgregarProducto_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(texCantidadAVender.Text) > Convert.ToInt32(texCantidadDisponible.Text))
            {
                MessageBox("", "La cantidad a vender no puede ser mayor que la cantidad disponible");
            }
            else
            {
                ListBox1.Items.Add(texNombre.Text);
                decimal valor = Convert.ToDecimal(texValor.Text);
                decimal descuento = Convert.ToDecimal(texDescuento.Text);
                int cantidadAVender = Convert.ToInt32(texCantidadAVender.Text);
                decimal total = Convert.ToDecimal(labValorTotal.Text);
                decimal discountPercentage = descuento / 100;
                decimal discountCalculated = valor * discountPercentage;
                decimal valueWithDiscount = valor - discountCalculated;
                decimal fullValue = valueWithDiscount * cantidadAVender;

                labValorTotal.Text = (total + fullValue).ToString();
                lisProductsIDs.Items.Add(labProductID.Text);
                butIngresarVenta.Enabled = true;
            }
        }

        private void MessageBox(string Title, string Message)
        {
            labMessage.Text = "<script>alert('" + Message + "')</script>";

        }

        protected void butIngresarVenta_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.ClientID = Convert.ToInt32(labCliente.Text);
            invoice.AdviserID = Convert.ToInt32(labAdvisorID.Text);
            invoice.Date = DateTime.Now;

            InvoiceBLL invoiceBLL = new InvoiceBLL();
            var inserted = invoiceBLL.PostWithProcedure(invoice);

            if (inserted != 0)
            {
                for (int i = 0; i <= lisProductsIDs.Items.Count - 1; i++)
                {
                    InvoiceDetail invoiceDetail = new InvoiceDetail();
                    invoiceDetail.InvoiceID = inserted;
                    invoiceDetail.ProductID = Convert.ToInt32(lisProductsIDs.Items[i].Value);
                    invoiceDetail.Quantity = Convert.ToInt32(texCantidadAVender.Text);
                    invoiceDetail.Discount = Convert.ToDecimal(texValor.Text) * (Convert.ToDecimal(texDescuento.Text) / 100);

                    InvoiceDetailBLL invoiceDetailBll = new InvoiceDetailBLL();
                    var detailInserted = invoiceDetailBll.PostWithProcedure(invoiceDetail);

                    ProductBLL productBLL = new ProductBLL();
                    var updated = productBLL.PutWithProcedure(Convert.ToInt32(lisProductsIDs.Items[i].Value), Convert.ToInt32(texCantidadAVender.Text));

                    if (updated != 0 && detailInserted != 0)
                    {
                        MessageBox("", "Venta ingresada");
                        texNombre.Text = "";
                        texValor.Text = "";
                        texCantidadDisponible.Text = "";
                        texDescuento.Text = "";
                        texReferencia.Text = "";
                        texCantidadAVender.Text = "";
                        labValorTotal.Text = "";

                        ListBox1.Items.Clear();
                        lisProductsIDs.Items.Clear();
                    }
                }

            }
        }
    }
}