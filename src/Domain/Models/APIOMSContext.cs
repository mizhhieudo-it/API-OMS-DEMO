using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.Models
{
    public partial class APIOMSContext : DbContext
    {
        public APIOMSContext()
        {
        }

        public APIOMSContext(DbContextOptions<APIOMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryProduct> CategoryProducts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Inventory> Inventories { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderExport> OrderExports { get; set; } = null!;
        public virtual DbSet<OrderImport> OrderImports { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductDetail> ProductDetails { get; set; } = null!;
        public virtual DbSet<Supperlier> Supperliers { get; set; } = null!;
        public virtual DbSet<TransactionType> TransactionTypes { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
        public virtual DbSet<WhArea> WhAreas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-446OBGB;Database=API-OMS;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryProduct>(entity =>
            {
                entity.ToTable("CategoryProduct");

                entity.Property(e => e.CategoryProductId).HasMaxLength(50);

                entity.Property(e => e.CategoryProductDescription).HasMaxLength(50);

                entity.Property(e => e.CategoryProductName).HasMaxLength(50);

                entity.Property(e => e.HandlerBy).HasMaxLength(50);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasMaxLength(50);

                entity.Property(e => e.CustomerAddress).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WardsId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inventory");

                entity.Property(e => e.InventoryId).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasMaxLength(50);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.InvoiceId).HasMaxLength(50);

                entity.Property(e => e.HandlerBy).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Invoices_Order");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasMaxLength(50);

                entity.Property(e => e.DateDelivered).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.DateRequired).HasColumnType("datetime");

                entity.Property(e => e.HandlerBy).HasMaxLength(50);

                entity.Property(e => e.OrderNote).HasMaxLength(50);

                entity.Property(e => e.OrderStatus).HasMaxLength(50);

                entity.Property(e => e.PackageCode).HasMaxLength(50);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Order_Customer");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderDetailId).HasMaxLength(50);

                entity.Property(e => e.HandlerBy).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.Prince).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<OrderExport>(entity =>
            {
                entity.HasKey(e => e.ExportOrderId);

                entity.ToTable("OrderExport");

                entity.Property(e => e.ExportOrderId).HasMaxLength(50);

                entity.Property(e => e.FromWarehouseId).HasMaxLength(50);

                entity.Property(e => e.HandlerBy).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.TimeChangeLocation).HasColumnType("datetime");

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");

                entity.Property(e => e.ToWarehouseId).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderImport>(entity =>
            {
                entity.ToTable("OrderImport");

                entity.Property(e => e.OrderImportId).HasMaxLength(50);

                entity.Property(e => e.ExpectedDelivery).HasColumnType("datetime");

                entity.Property(e => e.HandlerBy).HasMaxLength(50);

                entity.Property(e => e.OrderNote).HasMaxLength(50);

                entity.Property(e => e.ProductPrince).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductTotal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReferenceCode).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasMaxLength(50);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");

                entity.Property(e => e.ToWarehouseId).HasMaxLength(50);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasMaxLength(50);

                entity.Property(e => e.HandlerBy).HasMaxLength(50);

                entity.Property(e => e.InvoiceId).HasMaxLength(50);

                entity.Property(e => e.PaymentMethodId).HasMaxLength(50);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.Property(e => e.TransactionTypeId).HasMaxLength(50);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_Payment_Invoices");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_Payment_PaymentMethod");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("FK_Payment_TransactionType");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("PaymentMethod");

                entity.Property(e => e.PaymentMethodId).HasMaxLength(50);

                entity.Property(e => e.PaymentName).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.CategoryProductId).HasMaxLength(50);

                entity.Property(e => e.HandlerBy).HasMaxLength(255);

                entity.Property(e => e.OrderDetailId).HasMaxLength(50);

                entity.Property(e => e.OrderExportId).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.OrderImportId).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.SupperlierId).HasMaxLength(50);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");

                entity.Property(e => e.TrademarkId).HasMaxLength(50);

                entity.Property(e => e.WarehouseId).HasMaxLength(50);

                entity.HasOne(d => d.CategoryProduct)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryProductId)
                    .HasConstraintName("FK_Product_CategoryProduct");

                entity.HasOne(d => d.OrderImport)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.OrderImportId)
                    .HasConstraintName("FK_Product_OrderExport");

                entity.HasOne(d => d.OrderImportNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.OrderImportId)
                    .HasConstraintName("FK_Product_OrderImport");

                entity.HasOne(d => d.Supperlier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupperlierId)
                    .HasConstraintName("FK_Product_Supperlier");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_Product_Warehouse");
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.ToTable("ProductDetail");

                entity.Property(e => e.ProductDetailId).HasMaxLength(50);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .HasColumnName("BARCODE");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.HandlerBy).HasColumnType("datetime");

                entity.Property(e => e.HashTag).HasMaxLength(50);

                entity.Property(e => e.ImagesDescription).HasColumnType("text");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("IMEI");

                entity.Property(e => e.ImportPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ListedPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.ProductSku)
                    .HasMaxLength(50)
                    .HasColumnName("ProductSKU");

                entity.Property(e => e.RetailPrince).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TimeCreat).HasColumnType("datetime");

                entity.Property(e => e.TimeImportProduct).HasColumnType("date");

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductDetail_Product");
            });

            modelBuilder.Entity<Supperlier>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("Supperlier");

                entity.Property(e => e.SupplierId).HasMaxLength(50);

                entity.Property(e => e.BankOwnerName).HasMaxLength(50);

                entity.Property(e => e.HandlerBy).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.SupplierAddress).HasMaxLength(50);

                entity.Property(e => e.SupplierEmail).HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.SupplierNumber).HasMaxLength(50);

                entity.Property(e => e.SupplierTaxCode).HasMaxLength(50);

                entity.Property(e => e.SupplierType).HasMaxLength(50);

                entity.Property(e => e.SupplierWebsite).HasMaxLength(50);

                entity.Property(e => e.SupplierZipCode).HasMaxLength(50);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("TransactionType");

                entity.Property(e => e.TransactionTypeId).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.TransactionName).HasMaxLength(50);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("Warehouse");

                entity.Property(e => e.WarehouseId).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasColumnType("datetime");

                entity.Property(e => e.HandlerBy).HasColumnType("datetime");

                entity.Property(e => e.LocationMap).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasColumnType("datetime");

                entity.Property(e => e.WarehouseAddress).HasMaxLength(50);

                entity.Property(e => e.WarehouseName).HasMaxLength(50);

                entity.Property(e => e.WarehouseNameContact).HasMaxLength(50);

                entity.Property(e => e.WarehouseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WarehousePostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WhArea>(entity =>
            {
                entity.HasKey(e => e.IdWhArea);

                entity.ToTable("WhArea");

                entity.Property(e => e.IdWhArea).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.HandlerBy).HasMaxLength(50);

                entity.Property(e => e.IdWarehouse).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.HasOne(d => d.IdWarehouseNavigation)
                    .WithMany(p => p.WhAreas)
                    .HasForeignKey(d => d.IdWarehouse)
                    .HasConstraintName("FK_WhArea_Warehouse");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
