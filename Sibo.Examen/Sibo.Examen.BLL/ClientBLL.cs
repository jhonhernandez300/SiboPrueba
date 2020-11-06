using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Sibo.Examen.DAL.Model;
using Sibo.Examen.DAL.Model2;
using Sibo.Examen.DAL;

namespace Sibo.Examen.BLL
{
    public class ClientBLL
    {
        public ClientBLL() { }

        public IEnumerable<Client> Get()
        {
            try
            {
                ClientDAL oClient = new ClientDAL();
                return oClient.Get();
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }
        }

        public Client Post(Client client)
        {
            try
            {
                ClientDAL oClient = new ClientDAL();
                return oClient.Post(client);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }
        }
    }
}
