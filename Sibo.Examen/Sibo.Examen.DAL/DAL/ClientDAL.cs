using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Sibo.Examen.DAL.Model;
using Sibo.Examen.DAL.Model2;

namespace Sibo.Examen.DAL
{
    public class ClientDAL
    {
        public ClientDAL()
        { }

        public IEnumerable<Client> Get()
        {
            var lClients =new List<Client>();
            //using (var dbCtx = new SiboSupermarketEntities())
            using (var dbCtx = new SiboSupermarket1Entities1())
            {
                dbCtx.Configuration.ProxyCreationEnabled = false;
                lClients = dbCtx.Client.ToList();
            }
            return lClients.AsEnumerable();
        }

        public Client Post(Client client)
        {
            //using (var dbCtx = new SiboSupermarketEntities())
            using (var dbCtx = new SiboSupermarket1Entities1())
            {
                dbCtx.Configuration.ProxyCreationEnabled = false;
                dbCtx.Client.Add(client);
                int x=dbCtx.SaveChanges();
                return ((x > 0) ? client : null);
            }
        }


    }
}
