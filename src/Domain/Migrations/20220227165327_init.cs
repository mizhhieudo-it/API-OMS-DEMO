using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoryProductId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryProductDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => x.CategoryProductId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    ZipCode = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: true),
                    ProvinceId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DistrictId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WardsId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    InventoryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuantityPurchase = table.Column<int>(type: "int", nullable: true),
                    StockInHand = table.Column<int>(type: "int", nullable: true),
                    QuantitySold = table.Column<int>(type: "int", nullable: true),
                    QuantityLoss = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrderExport",
                columns: table => new
                {
                    ExportOrderId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: true),
                    FromWarehouseId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ToWarehouseId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TimeChangeLocation = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderExport", x => x.ExportOrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderImport",
                columns: table => new
                {
                    OrderImportId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupplierId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ToWarehouseId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReferenceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductQuantity = table.Column<int>(type: "int", nullable: true),
                    ProductPrince = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ProductTotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ExpectedDelivery = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderNote = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderImport", x => x.OrderImportId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Supperlier",
                columns: table => new
                {
                    SupplierId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupplierType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupplierName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupplierEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupplierNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupplierWebsite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupplierAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupplierTaxCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupplierZipCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupperlierBankNumber = table.Column<long>(type: "bigint", nullable: true),
                    SupperlierBankType = table.Column<int>(type: "int", nullable: true),
                    BankOwnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupperlierStatus = table.Column<int>(type: "int", nullable: true),
                    TimeCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supperlier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    TransactionTypeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransactionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.TransactionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    WarehouseId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WarehouseNameContact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WarehouseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WarehouseAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WarehousePostalCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    DistrinctId = table.Column<int>(type: "int", nullable: true),
                    CommuneId = table.Column<int>(type: "int", nullable: true),
                    LocationMap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateBy = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateRequired = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateDelivered = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PackageCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderNote = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Customer",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderDetailId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupperlierId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrademarkId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WarehouseId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryProductId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderImportId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderExportId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_CategoryProduct",
                        column: x => x.CategoryProductId,
                        principalTable: "CategoryProduct",
                        principalColumn: "CategoryProductId");
                    table.ForeignKey(
                        name: "FK_Product_OrderExport",
                        column: x => x.OrderImportId,
                        principalTable: "OrderExport",
                        principalColumn: "ExportOrderId");
                    table.ForeignKey(
                        name: "FK_Product_OrderImport",
                        column: x => x.OrderImportId,
                        principalTable: "OrderImport",
                        principalColumn: "OrderImportId");
                    table.ForeignKey(
                        name: "FK_Product_Supperlier",
                        column: x => x.SupperlierId,
                        principalTable: "Supperlier",
                        principalColumn: "SupplierId");
                    table.ForeignKey(
                        name: "FK_Product_Warehouse",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "WarehouseId");
                });

            migrationBuilder.CreateTable(
                name: "WhArea",
                columns: table => new
                {
                    IdWhArea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdWarehouse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhArea", x => x.IdWhArea);
                    table.ForeignKey(
                        name: "FK_WhArea_Warehouse",
                        column: x => x.IdWarehouse,
                        principalTable: "Warehouse",
                        principalColumn: "WarehouseId");
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Order",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Prince = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    TimeCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "ProductDetail",
                columns: table => new
                {
                    ProductDetailId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductType = table.Column<int>(type: "int", nullable: true),
                    ProductSKU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BARCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HashTag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IMEI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImagesDescription = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImportPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ListedPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    RetailPrince = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    NumberStockWaring = table.Column<int>(type: "int", nullable: true),
                    TimeImportProduct = table.Column<DateTime>(type: "date", nullable: true),
                    ProductHeight = table.Column<double>(type: "float", nullable: true),
                    ProductWidth = table.Column<double>(type: "float", nullable: true),
                    ProductLength = table.Column<double>(type: "float", nullable: true),
                    TimeCreat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetail", x => x.ProductDetailId);
                    table.ForeignKey(
                        name: "FK_ProductDetail_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InvoiceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaymentMethodId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransactionTypeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimeCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HandlerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Invoices",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId");
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMethod",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "PaymentMethodId");
                    table.ForeignKey(
                        name: "FK_Payment_TransactionType",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionType",
                        principalColumn: "TransactionTypeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OrderId",
                table: "Invoices",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_InvoiceId",
                table: "Payment",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentMethodId",
                table: "Payment",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_TransactionTypeId",
                table: "Payment",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryProductId",
                table: "Product",
                column: "CategoryProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderImportId",
                table: "Product",
                column: "OrderImportId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SupperlierId",
                table: "Product",
                column: "SupperlierId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_WarehouseId",
                table: "Product",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductId",
                table: "ProductDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WhArea_IdWarehouse",
                table: "WhArea",
                column: "IdWarehouse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "ProductDetail");

            migrationBuilder.DropTable(
                name: "WhArea");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "OrderExport");

            migrationBuilder.DropTable(
                name: "OrderImport");

            migrationBuilder.DropTable(
                name: "Supperlier");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
