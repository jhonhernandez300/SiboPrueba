using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Sibo.Examen.DAL.Model;
using Sibo.Examen.DAL.Model2;

namespace Sibo.Examen.DAL
{
    public class AdviserDAL
    {
        public AdviserDAL()
        {
        }

        public Adviser GetAdviser(string User, string Pass)
        {
            var eAdviser = new Adviser();
            //using (var dbCtx = new SiboSupermarketEntities())
            using (var dbCtx = new Model2.SiboSupermarket1Entities1())            
            {
                dbCtx.Configuration.ProxyCreationEnabled = false;
                eAdviser=dbCtx.Adviser.FirstOrDefault(x => x.Identification == User && x.Password == Pass);                
            }
            return eAdviser;
        }
    }
}
