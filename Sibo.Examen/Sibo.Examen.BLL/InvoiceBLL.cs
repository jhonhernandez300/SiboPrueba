using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sibo.Examen.DAL.Model2;
using Sibo.Examen.DAL;
using System.Data;

namespace Sibo.Examen.BLL
{
    public class InvoiceBLL
    {
        public Invoice Post(Invoice invoice)
        {
            try
            {
               InvoiceDAL invoiceDal = new InvoiceDAL();
                return invoiceDal.Post(invoice);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }
        }

        public int PostWithProcedure(Invoice invoice)
        {
            try
            {
                InvoiceDAL invoiceDal = new InvoiceDAL();
                return invoiceDal.PostWithProcedure(invoice);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }
        }

    }
}
