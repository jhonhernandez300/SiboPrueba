using Sibo.Examen.DAL.Model2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sibo.Examen.DAL;

namespace Sibo.Examen.BLL
{
    public class InvoiceDetailBLL
    {
        public InvoiceDetail Post(InvoiceDetail invoiceDetail)
        {
            try
            {
                InvoiceDetailDAL invoiceDetailDal = new InvoiceDetailDAL();
                return invoiceDetailDal.Post(invoiceDetail);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }
        }

        public int PostWithProcedure(InvoiceDetail invoiceDetail)
        {
            try
            {
                InvoiceDetailDAL invoiceDetailDal = new InvoiceDetailDAL();
                return invoiceDetailDal.PostWithProcedure(invoiceDetail);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }
        }

    }
}
