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
    public class ProductDAL
    {
        public Product Get(int id)
        {
            var theProduct = new Product();

            using (var context = new SiboSupermarket1Entities1())
            {
                context.Configuration.ProxyCreationEnabled = false;
                theProduct = context.Product.FirstOrDefault(x => x.ProductID == id);
            };
            return theProduct;
        }

        public Product Put(int id, int amount)
        {
            var theProduct = new Product();

            using (var context = new SiboSupermarket1Entities1())
            {
                context.Configuration.ProxyCreationEnabled = false;
                theProduct = context.Product.FirstOrDefault(y => y.ProductID == id);

                if (theProduct != null)
                {
                    theProduct.Quantity = theProduct.Quantity - amount;
                    int x = context.SaveChanges();
                    return ((x > 0) ? theProduct : null);
                }
                else
                {
                    return null;
                }               
                
            }
        }

        public int PutWithProcedure(int id, int amount)
        {
            try
            {
                //string connectionString = "SiboSupermarket1Entities1' connectionString = 'metadata=res://*/Model2.ModelSiboSuperMarket2.csdl|res://*/Model2.ModelSiboSuperMarket2.ssdl|res://*/Model2.ModelSiboSuperMarket2.msl;provider=System.Data.SqlClient; 'provider connection string=&quot; Data Source=DESKTOP-APHO8VE\\SQLEXPRESS;Initial Catalog=SiboSupermarket1;Integrated Security=True; MultipleActiveResultSets=False&quot;' providerName = 'System.Data.EntityClient'";

                //string connectionString = ConfigurationManager.ConnectionStrings["SiboSupermarket1Entities1"].ToString();
                string connectionString = "Data Source=DESKTOP-APHO8VE\\SQLEXPRESS;Initial Catalog=SiboSupermarket1;Integrated Security=True;";
                var con = new SqlConnection(connectionString);

                string UpdateCommand = "spUpdateProduct2";
                using (SqlConnection sqlConnectionCmdString = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlRenameCommand = new SqlCommand(UpdateCommand, sqlConnectionCmdString))
                    {                        
                        sqlRenameCommand.CommandType = CommandType.StoredProcedure;
                        sqlRenameCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                        sqlRenameCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = amount;
                        sqlConnectionCmdString.Open();
                        sqlRenameCommand.ExecuteNonQuery();
                        return 1;
                    }
                }                                
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error en la aplicacion", ex);
            }
        }

    }
}
