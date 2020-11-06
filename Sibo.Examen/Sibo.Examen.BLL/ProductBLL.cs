using Sibo.Examen.DAL.Model2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sibo.Examen.DAL;

namespace Sibo.Examen.BLL
{
    public class ProductBLL
    {

        public Product Get(int id)
        {
            try
            {
                ProductDAL productDal = new ProductDAL();
                return productDal.Get(id);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }
        }

        public Product Put(int id, int amount)
        {
            try
            {
                ProductDAL productDal = new ProductDAL();
                return productDal.Put(id, amount);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }

        }

        public int PutWithProcedure(int id, int amount)
        {
            try
            {
                ProductDAL productDal = new ProductDAL();
                return productDal.PutWithProcedure(id, amount);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }

        }

    }
}
