﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PTCar;

#nullable disable

namespace PTCar.Migrations
{
    [DbContext(typeof(ASMDBContext))]
    [Migration("20241126033257_CreatePTCAR2")]
    partial class CreatePTCAR2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PTCar.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseHistory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("PTCar.Inventory", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryID"));

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.Property<string>("StoredProducts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Warehouselocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventoryID");

                    b.HasIndex("ProductID");

                    b.ToTable("inventories");
                });

            modelBuilder.Entity("PTCar.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Invoicedate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListofProducts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InvoiceID");

                    b.HasIndex("CustomerID");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("PTCar.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProdcutList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("StaffID");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("PTCar.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("StaffID")
                        .HasColumnType("int");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("StaffID");

                    b.HasIndex("SupplierID");

                    b.ToTable("products");
                });

            modelBuilder.Entity("PTCar.Staff", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WorkingDay")
                        .HasColumnType("datetime2");

                    b.HasKey("StaffID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("PTCar.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("PTCar.Inventory", b =>
                {
                    b.HasOne("PTCar.Product", "product")
                        .WithMany("inventories")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("PTCar.Invoice", b =>
                {
                    b.HasOne("PTCar.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PTCar.Order", b =>
                {
                    b.HasOne("PTCar.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PTCar.Staff", "Staff")
                        .WithMany("Orders")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("PTCar.Product", b =>
                {
                    b.HasOne("PTCar.Staff", null)
                        .WithMany("Products")
                        .HasForeignKey("StaffID");

                    b.HasOne("PTCar.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("PTCar.Customer", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PTCar.Product", b =>
                {
                    b.Navigation("inventories");
                });

            modelBuilder.Entity("PTCar.Staff", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("PTCar.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
