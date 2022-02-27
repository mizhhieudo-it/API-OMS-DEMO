using Domain.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public interface IOMSUnitOfWork: IUnitOfWork, IDisposable
    {
        // resgister ctor 
        IRepository<CategoryProduct> CategoryProduct { get; }
        IRepository<Customer> Customer { get; }
        IRepository<Inventory> Inventory { get; }
        IRepository<Invoice> Invoice { get; }
        IRepository<Order> Order { get; }
        IRepository<OrderDetail> OrderDetail { get; }
        IRepository<OrderExport> OrderExport { get; }
        IRepository<OrderImport> OrderImport { get; }
        IRepository<Payment> Payment { get; }
        IRepository<PaymentMethod> PaymentMethod { get; }
        IRepository<Product> Product { get; }
        IRepository<ProductDetail> ProductDetail { get; }
        IRepository<Supperlier> Supperlier { get; }
        IRepository<TransactionType> TransactionType { get; }
        IRepository<Warehouse> Warehouse { get; }
        IRepository<WhArea> WhArea { get; }
    }
}
