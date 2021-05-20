﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PenTrade.Models;

namespace PenTrade.WebMvc.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190609120825_AddIsOfferToBuy")]
    partial class AddIsOfferToBuy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("PenTrade.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("PenTrade.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("PenTrade.Models.CurrentStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AmountOfMerchandise");

                    b.Property<int>("CompanyId");

                    b.Property<int>("MerchandiseId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("MerchandiseId");

                    b.ToTable("CurrentStocks");
                });

            modelBuilder.Entity("PenTrade.Models.Merchandise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Merchandises");
                });

            modelBuilder.Entity("PenTrade.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int?>("NegotiationId");

                    b.Property<int>("ReceiverId");

                    b.Property<int>("SenderId");

                    b.Property<DateTime>("TimeSent");

                    b.HasKey("Id");

                    b.HasIndex("NegotiationId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("PenTrade.Models.Negotiation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Company1Id");

                    b.Property<int>("Company2Id");

                    b.HasKey("Id");

                    b.HasIndex("Company1Id");

                    b.HasIndex("Company2Id");

                    b.ToTable("Negotiations");
                });

            modelBuilder.Entity("PenTrade.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<bool?>("IsAccepted");

                    b.Property<bool>("IsOfferToBuy");

                    b.Property<int>("MerchandiseId");

                    b.Property<int?>("NegotiationId");

                    b.Property<double>("PricePerUnit");

                    b.Property<int>("ReceiverId");

                    b.Property<int>("SenderId");

                    b.Property<DateTime>("TimeSent");

                    b.HasKey("Id");

                    b.HasIndex("MerchandiseId");

                    b.HasIndex("NegotiationId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("PenTrade.Models.ApplicationUser", b =>
                {
                    b.HasOne("PenTrade.Models.Company", "Company")
                        .WithMany("Representatives")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("PenTrade.Models.CurrentStock", b =>
                {
                    b.HasOne("PenTrade.Models.Company", "Company")
                        .WithMany("CurrentStock")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PenTrade.Models.Merchandise", "Merchandise")
                        .WithMany()
                        .HasForeignKey("MerchandiseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PenTrade.Models.Message", b =>
                {
                    b.HasOne("PenTrade.Models.Negotiation")
                        .WithMany("Messages")
                        .HasForeignKey("NegotiationId");

                    b.HasOne("PenTrade.Models.Company", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PenTrade.Models.Company", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PenTrade.Models.Negotiation", b =>
                {
                    b.HasOne("PenTrade.Models.Company", "Company1")
                        .WithMany()
                        .HasForeignKey("Company1Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PenTrade.Models.Company", "Company2")
                        .WithMany()
                        .HasForeignKey("Company2Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PenTrade.Models.Offer", b =>
                {
                    b.HasOne("PenTrade.Models.Merchandise", "Merchandise")
                        .WithMany()
                        .HasForeignKey("MerchandiseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PenTrade.Models.Negotiation")
                        .WithMany("Offers")
                        .HasForeignKey("NegotiationId");

                    b.HasOne("PenTrade.Models.Company", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PenTrade.Models.Company", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
