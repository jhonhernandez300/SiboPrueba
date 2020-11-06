using Sibo.Examen.DAL.Model2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibo.Examen.DAL
{
    public class InvoiceDetailDAL
    {
        public InvoiceDetail Post(InvoiceDetail invoiceDetail)
        {
            using (var context = new SiboSupermarket1Entities1())
            {
                context.Configuration.ProxyCreationEnabled = false;
                context.InvoiceDetail.Add(invoiceDetail);
                int x = context.SaveChanges();
                return ((x > 0) ? invoiceDetail : null);
            }
        }

       
        public int PostWithProcedure(InvoiceDetail invoiceDetail)
        {
            try
            {
                //string connectionString = "SiboSupermarket1Entities1' connectionString = 'metadata=res://*/Model2.ModelSiboSuperMarket2.csdl|res://*/Model2.ModelSiboSuperMarket2.ssdl|res://*/Model2.ModelSiboSuperMarket2.msl;provider=System.Data.SqlClient; 'provider connection string=&quot; Data Source=DESKTOP-APHO8VE\\SQLEXPRESS;Initial Catalog=SiboSupermarket1;Integrated Security=True; MultipleActiveResultSets=False&quot;' providerName = 'System.Data.EntityClient'";
                //var con = new SqlConnection(connectionString);
                string connectionString = "Data Source=DESKTOP-APHO8VE\\SQLEXPRESS;Initial Catalog=SiboSupermarket1;Integrated Security=True;";
                //string connectionString = ConfigurationManager.ConnectionStrings["SiboSupermarket1Entities1"].ToString();
                var con = new SqlConnection(connectionString);

                con.Open();
                var cmd = new SqlCommand();
                cmd.CommandText = "spSaveInvoiceDetail";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@InvoiceID", invoiceDetail.InvoiceID);
                cmd.Parameters.AddWithValue("@ProductID", invoiceDetail.ProductID);
                cmd.Parameters.AddWithValue("@Quantity", invoiceDetail.Quantity);
                cmd.Parameters.AddWithValue("@Discount", invoiceDetail.Discount);
                cmd.Parameters.Add("@LastID", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                int modified = Convert.ToInt32(cmd.Parameters["@LastID"].Value);
                con.Close();                
                return modified;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error en la aplicacion", ex);
            }
        }
    }
}
