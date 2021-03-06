﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sibo.Examen.DAL.Model2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SiboSupermarket1Entities1 : DbContext
    {
        public SiboSupermarket1Entities1()
            : base("name=SiboSupermarket1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adviser> Adviser { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<Product> Product { get; set; }
    
        public virtual int spSaveInvoice2(Nullable<int> clientID, Nullable<int> adviserID, ObjectParameter lastID)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            var adviserIDParameter = adviserID.HasValue ?
                new ObjectParameter("AdviserID", adviserID) :
                new ObjectParameter("AdviserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveInvoice2", clientIDParameter, adviserIDParameter, lastID);
        }
    
        public virtual int spSaveInvoiceDetail(Nullable<int> invoiceID, Nullable<int> productID, Nullable<int> quantity, Nullable<decimal> discount, ObjectParameter lastID)
        {
            var invoiceIDParameter = invoiceID.HasValue ?
                new ObjectParameter("InvoiceID", invoiceID) :
                new ObjectParameter("InvoiceID", typeof(int));
    
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("Discount", discount) :
                new ObjectParameter("Discount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveInvoiceDetail", invoiceIDParameter, productIDParameter, quantityParameter, discountParameter, lastID);
        }
    
        public virtual int spStoreTransaction(Nullable<int> clientID, Nullable<int> adviserID, Nullable<System.DateTime> theDate, Nullable<int> productID, Nullable<int> quantityUsed, Nullable<decimal> percentDiscount, Nullable<decimal> discount, Nullable<decimal> price)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            var adviserIDParameter = adviserID.HasValue ?
                new ObjectParameter("AdviserID", adviserID) :
                new ObjectParameter("AdviserID", typeof(int));
    
            var theDateParameter = theDate.HasValue ?
                new ObjectParameter("TheDate", theDate) :
                new ObjectParameter("TheDate", typeof(System.DateTime));
    
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            var quantityUsedParameter = quantityUsed.HasValue ?
                new ObjectParameter("QuantityUsed", quantityUsed) :
                new ObjectParameter("QuantityUsed", typeof(int));
    
            var percentDiscountParameter = percentDiscount.HasValue ?
                new ObjectParameter("PercentDiscount", percentDiscount) :
                new ObjectParameter("PercentDiscount", typeof(decimal));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("Discount", discount) :
                new ObjectParameter("Discount", typeof(decimal));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spStoreTransaction", clientIDParameter, adviserIDParameter, theDateParameter, productIDParameter, quantityUsedParameter, percentDiscountParameter, discountParameter, priceParameter);
        }
    
        public virtual int spUpdateProduct2(Nullable<int> quantity, Nullable<int> iD)
        {
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateProduct2", quantityParameter, iDParameter);
        }
    }
}
