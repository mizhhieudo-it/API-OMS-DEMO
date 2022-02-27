using Domain.Models;
using Repository;
using UnitOfWork;

namespace OMS_API.Config
{
    public static class RegisterD
    {
        //IServiceCollection
        public static void RegisterDependencyInjection(this IServiceCollection builder) 
        {
            builder.AddTransient<IOMSUnitOfWork, OMSUnitOfWork>();
            builder.AddTransient<APIOMSContext>();
            builder.AddSingleton<IRepository<CategoryProduct>, Repository<CategoryProduct>>();
            builder.AddSingleton<IRepository<Customer>, Repository<Customer>>();
            builder.AddSingleton<IRepository<Inventory>, Repository<Inventory>>();
            builder.AddSingleton<IRepository<Invoice>, Repository<Invoice>>();
            builder.AddSingleton<IRepository<Order>, Repository<Order>>();
            builder.AddSingleton<IRepository<OrderDetail>, Repository<OrderDetail>>();
            builder.AddSingleton<IRepository<OrderExport>, Repository<OrderExport>>();
            builder.AddSingleton<IRepository<OrderImport>, Repository<OrderImport>>();
            builder.AddSingleton<IRepository<Payment>, Repository<Payment>>();
            builder.AddSingleton<IRepository<PaymentMethod>, Repository<PaymentMethod>>();
            builder.AddSingleton<IRepository<Product>, Repository<Product>>();
            builder.AddSingleton<IRepository<ProductDetail>, Repository<ProductDetail>>();
            builder.AddSingleton<IRepository<Supperlier>, Repository<Supperlier>>();
            builder.AddSingleton<IRepository<TransactionType>, Repository<TransactionType>>();
            builder.AddSingleton<IRepository<Warehouse>, Repository<Warehouse>>();
            builder.AddSingleton<IRepository<WhArea>, Repository<WhArea>>();
        }
    }
}
