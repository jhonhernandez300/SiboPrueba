using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//using Sibo.Examen.DAL.Model;
using Sibo.Examen.DAL.Model2;
using Sibo.Examen.BLL;
using System.Data;
using System.Reflection;

namespace Sibo.Examen.Service
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    //[Serializable]
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable Get()
        {
            ClientBLL oClient = new ClientBLL();
            IEnumerable<Client> lClient= oClient.Get();
            return ToDataTable<Client>(lClient.ToList());
        }

        [WebMethod]
        public Client Post(string Identification, string Name, string LastName)
        {
            
            Client eClient = new Client { Identification = Identification, Name = Name, LastName = LastName };
            ClientBLL oClient = new ClientBLL();
            var newClient = oClient.Post(eClient);
            return ((newClient != null) ? newClient : null) ;
             
        }


        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }

            foreach (T item in items)
            {
                var values = new object[Props.Length];

                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
