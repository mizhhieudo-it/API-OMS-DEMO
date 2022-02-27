using Domain.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public class OMSUnitOfWork:UnitOfWorkBase, IOMSUnitOfWork
    {
        private IRepository<CategoryProduct> _CategoryProduct;
        private IRepository<Customer> _Customer;
        private IRepository<Inventory> _Inventory;
        private IRepository<Invoice> _Invoice ;
        private IRepository<Order> _Order ;
        private IRepository<OrderDetail> _OrderDetail ;
        private IRepository<OrderExport> _OrderExport ;
        private IRepository<OrderImport> _OrderImport ;
        private IRepository<Payment> _Payment ;
        private IRepository<PaymentMethod> _PaymentMethod ;
        private IRepository<Product> _Product ;
        private IRepository<ProductDetail> _ProductDetail ;
        private IRepository<Supperlier> _Supperlier;
        private IRepository<TransactionType> _TransactionType ;
        private IRepository<Warehouse> _Warehouse ;
        private IRepository<WhArea> _WhArea ;

        public OMSUnitOfWork(APIOMSContext context) : base(context)
        {
        }

        // public Repo 

        public IRepository<CategoryProduct> CategoryProduct
        {
            get {
                _CategoryProduct = new Repository<CategoryProduct>(_dbContext);
                return _CategoryProduct;
            }
        }

        public IRepository<Customer> Customer
        {
            get
            {
                _Customer = new Repository<Customer>(_dbContext);
                return _Customer;
            }
        }

        public IRepository<Inventory> Inventory
        {
            get
            {
                _Inventory = new Repository<Inventory>(_dbContext);
                return _Inventory;
            }
        }

        public IRepository<Invoice> Invoice
        {
            get
            {
               _Invoice = new Repository<Invoice>(_dbContext);
                return _Invoice;
            }
        }

        public IRepository<Order> Order
        {
            get
            {
                _Order = new Repository<Order>(_dbContext);
                return _Order;
            }
        }

        public IRepository<OrderDetail> OrderDetail
        {
            get
            {
                _OrderDetail = new Repository<OrderDetail>(_dbContext);
                return _OrderDetail;
            }
        }

        public IRepository<OrderExport> OrderExport
        {
            get
            {
                _OrderExport = new Repository<OrderExport>(_dbContext);
                return _OrderExport;
            }
        }

        public IRepository<OrderImport> OrderImport
        {
            get
            {
                _OrderImport = new Repository<OrderImport>(_dbContext);
                return _OrderImport;
            }
        }

        public IRepository<Payment> Payment
        {
            get { 
               _Payment = new Repository<Payment>(_dbContext);
                return _Payment;
            }
        }

        public IRepository<PaymentMethod> PaymentMethod
        {
            get
            {
                _PaymentMethod = new Repository<PaymentMethod>(_dbContext);
                return _PaymentMethod;
            }
        }

        public IRepository<Product> Product
        {
            get
            {
                _Product = new Repository<Product>(_dbContext);
                return _Product;
            }
        }

        public IRepository<ProductDetail> ProductDetail
        {
            get
            {
                _ProductDetail = new Repository<ProductDetail>(_dbContext);
                return _ProductDetail;
            }
        }

        public IRepository<Supperlier> Supperlier
        {
            get
            {
                _Supperlier = new Repository<Supperlier>(_dbContext);
                return _Supperlier;
            }
        }

        public IRepository<TransactionType> TransactionType
        {
            get
            {
                _TransactionType = new Repository<TransactionType>(_dbContext); 
                return _TransactionType;
            }
        }

        public IRepository<Warehouse> Warehouse
        {
            get
            {
                _Warehouse = new Repository<Warehouse>(_dbContext);
                return _Warehouse;
            }
        }
        public IRepository<WhArea> WhArea
        {
            get
            {
                _WhArea = new Repository<WhArea>(_dbContext);
                return _WhArea;
            }
        }

        

        // public repository 


        

    }
}
