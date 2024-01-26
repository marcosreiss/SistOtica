﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistOtica.Data;

#nullable disable

namespace SistOtica.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240124152541_fix-clientModel")]
    partial class fixclientModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductModelSaleModel", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("SalesId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "SalesId");

                    b.HasIndex("SalesId");

                    b.ToTable("ProductModelSaleModel");
                });

            modelBuilder.Entity("SaleModelServiceModel", b =>
                {
                    b.Property<int>("SalesId")
                        .HasColumnType("int");

                    b.Property<int>("ServicesId")
                        .HasColumnType("int");

                    b.HasKey("SalesId", "ServicesId");

                    b.HasIndex("ServicesId");

                    b.ToTable("SaleModelServiceModel");
                });

            modelBuilder.Entity("SistOtica.Models.Client.ClientContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("SistOtica.Models.Client.ClientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressComplement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("BornDate")
                        .HasColumnType("date");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Negativated")
                        .HasColumnType("bit");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ocupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SistOtica.Models.Client.ClientReferences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("References");
                });

            modelBuilder.Entity("SistOtica.Models.Product.BrandModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("SistOtica.Models.Product.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Addition")
                        .HasColumnType("float");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<double>("BuyPrice")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SistOtica.Models.Sale.FrameModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ref")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Frames");
                });

            modelBuilder.Entity("SistOtica.Models.Sale.PaymentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<double>("DownPayment")
                        .HasColumnType("float");

                    b.Property<DateOnly>("DueDate")
                        .HasColumnType("date");

                    b.Property<int>("Installments")
                        .HasColumnType("int");

                    b.Property<int>("Method")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SaleId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("SistOtica.Models.Sale.PrescriptionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Adicao")
                        .HasColumnType("float");

                    b.Property<double>("CentroOtico")
                        .HasColumnType("float");

                    b.Property<string>("Crm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OdCilindrico")
                        .HasColumnType("float");

                    b.Property<double>("OdDnp")
                        .HasColumnType("float");

                    b.Property<double>("OdEixo")
                        .HasColumnType("float");

                    b.Property<double>("OdEsferico")
                        .HasColumnType("float");

                    b.Property<double>("OeCilindrico")
                        .HasColumnType("float");

                    b.Property<double>("OeDnp")
                        .HasColumnType("float");

                    b.Property<double>("OeEixo")
                        .HasColumnType("float");

                    b.Property<double>("OeEsferico")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("SistOtica.Models.Sale.SaleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<double>("FinalPrice")
                        .HasColumnType("float");

                    b.Property<int>("FrameId")
                        .HasColumnType("int");

                    b.Property<int>("ItemQt")
                        .HasColumnType("int");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProtocolId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("SaleDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("FrameId")
                        .IsUnique();

                    b.HasIndex("ProtocolId")
                        .IsUnique();

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("SistOtica.Models.Sale.SaleProtocolModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Book")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Page")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrescriptionId")
                        .IsUnique();

                    b.ToTable("SaleProtocols");
                });

            modelBuilder.Entity("SistOtica.Models.Service.ServiceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ProductModelSaleModel", b =>
                {
                    b.HasOne("SistOtica.Models.Product.ProductModel", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistOtica.Models.Sale.SaleModel", null)
                        .WithMany()
                        .HasForeignKey("SalesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SaleModelServiceModel", b =>
                {
                    b.HasOne("SistOtica.Models.Sale.SaleModel", null)
                        .WithMany()
                        .HasForeignKey("SalesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistOtica.Models.Service.ServiceModel", null)
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistOtica.Models.Client.ClientContact", b =>
                {
                    b.HasOne("SistOtica.Models.Client.ClientModel", "Client")
                        .WithMany("PhoneNumber")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("SistOtica.Models.Client.ClientReferences", b =>
                {
                    b.HasOne("SistOtica.Models.Client.ClientModel", "Client")
                        .WithMany("References")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("SistOtica.Models.Product.ProductModel", b =>
                {
                    b.HasOne("SistOtica.Models.Product.BrandModel", "brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brand");
                });

            modelBuilder.Entity("SistOtica.Models.Sale.PaymentModel", b =>
                {
                    b.HasOne("SistOtica.Models.Sale.SaleModel", "Sale")
                        .WithOne("Payment")
                        .HasForeignKey("SistOtica.Models.Sale.PaymentModel", "SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("SistOtica.Models.Sale.SaleModel", b =>
                {
                    b.HasOne("SistOtica.Models.Client.ClientModel", "Client")
                        .WithMany("Sales")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistOtica.Models.Sale.FrameModel", "Frame")
                        .WithOne("Sale")
                        .HasForeignKey("SistOtica.Models.Sale.SaleModel", "FrameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistOtica.Models.Sale.SaleProtocolModel", "Protocol")
                        .WithOne("Sale")
                        .HasForeignKey("SistOtica.Models.Sale.SaleModel", "ProtocolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Frame");

                    b.Navigation("Protocol");
                });

            modelBuilder.Entity("SistOtica.Models.Sale.SaleProtocolModel", b =>
                {
                    b.HasOne("SistOtica.Models.Sale.PrescriptionModel", "Prescription")
                        .WithOne("Protocol")
                        .HasForeignKey("SistOtica.Models.Sale.SaleProtocolModel", "PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("SistOtica.Models.Client.ClientModel", b =>
                {
                    b.Navigation("PhoneNumber");

                    b.Navigation("References");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("SistOtica.Models.Product.BrandModel", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SistOtica.Models.Sale.FrameModel", b =>
                {
                    b.Navigation("Sale")
                        .IsRequired();
                });

            modelBuilder.Entity("SistOtica.Models.Sale.PrescriptionModel", b =>
                {
                    b.Navigation("Protocol")
                        .IsRequired();
                });

            modelBuilder.Entity("SistOtica.Models.Sale.SaleModel", b =>
                {
                    b.Navigation("Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("SistOtica.Models.Sale.SaleProtocolModel", b =>
                {
                    b.Navigation("Sale")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
