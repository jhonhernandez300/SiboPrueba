using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sibo.Examen.DAL.Model2;
using System.Configuration;

namespace Sibo.Examen.DAL
{
    public class InvoiceDAL
    {
        public Invoice Post(Invoice invoice)
        {
            using (var context = new SiboSupermarket1Entities1())
            {
                context.Configuration.ProxyCreationEnabled = false;
                context.Invoice.Add(invoice);
                int x = context.SaveChanges();
                return ((x > 0) ? invoice : null);
            }
        }

        public int PostWithProcedure(Invoice invoice)
        {
            try
            {
               //string connectionString = "SiboSupermarket1Entities1' connectionString = 'metadata=res://*/Model2.ModelSiboSuperMarket2.csdl|res://*/Model2.ModelSiboSuperMarket2.ssdl|res://*/Model2.ModelSiboSuperMarket2.msl;provider=System.Data.SqlClient; 'provider connection string=&quot; Data Source=DESKTOP-APHO8VE\\SQLEXPRESS;Initial Catalog=SiboSupermarket1;Integrated Security=True; MultipleActiveResultSets=False&quot;' providerName = 'System.Data.EntityClient'";
                string connectionString = "Data Source=DESKTOP-APHO8VE\\SQLEXPRESS;Initial Catalog=SiboSupermarket1;Integrated Security=True;";
                //var con = new SqlConnection(connectionString);
                //string connectionString = ConfigurationManager.ConnectionStrings["SiboSupermarket1Entities1"].ToString();
                var con = new SqlConnection(connectionString);

                con.Open();
                var cmd = new SqlCommand();
                cmd.CommandText = "spSaveInvoice2";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                
                cmd.Parameters.AddWithValue("@ClientID", invoice.ClientID);
                cmd.Parameters.AddWithValue("@AdviserID", invoice.AdviserID);
                cmd.Parameters.Add("@LastID", SqlDbType.Int).Direction = ParameterDirection.Output;
                
                cmd.ExecuteNonQuery();
                int modified = Convert.ToInt32(cmd.Parameters["@LastID"].Value);                

                con.Close();                
                return modified;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }      
                
        

    }
}
