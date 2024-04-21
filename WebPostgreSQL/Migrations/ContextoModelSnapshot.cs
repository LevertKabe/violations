﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebPostgreSQL.Models;

#nullable disable

namespace WebPostgreSQL.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebPostgreSQL.Models.AnnualTax", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DateIssued");

                    b.Property<bool>("IsPayed")
                        .HasColumnType("boolean")
                        .HasColumnName("IsPayed");

                    b.HasKey("Id");

                    b.ToTable("AnnualTax");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("AnnualTaxId")
                        .HasColumnType("uuid");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Colour");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Model");

                    b.Property<string>("NumberPlate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NumberPlate");

                    b.Property<string>("RegisteredOwner")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("RegisteredOwner");

                    b.Property<string>("VinNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("VinNumber");

                    b.Property<string>("ViolatorId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AnnualTaxId")
                        .IsUnique();

                    b.HasIndex("ViolatorId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Officer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Address");

                    b.Property<string>("BadgeNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("BadgeNumber");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("EmailAddress");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Officer");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision")
                        .HasColumnName("Amount");

                    b.Property<string>("PayMethod")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("PayMethod");

                    b.Property<DateTime>("ProcessDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ProcessDate");

                    b.Property<Guid>("ViolationId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Violation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision")
                        .HasColumnName("Amount");

                    b.Property<Guid>("AnnualTaxId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DateIssued");

                    b.Property<bool>("IsPayed")
                        .HasColumnType("boolean")
                        .HasColumnName("IsPayed");

                    b.Property<Guid>("IssueOfficerId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IssuedCarId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uuid");

                    b.Property<string>("ViolationType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ViolationType");

                    b.HasKey("Id");

                    b.HasIndex("AnnualTaxId");

                    b.HasIndex("IssueOfficerId");

                    b.HasIndex("IssuedCarId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.ToTable("Violation");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Violator", b =>
                {
                    b.Property<string>("IDNumber")
                        .HasColumnType("text")
                        .HasColumnName("IDNumber");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Address");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("EmailAddress");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("IDNumber");

                    b.ToTable("Violator");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Car", b =>
                {
                    b.HasOne("WebPostgreSQL.Models.AnnualTax", "AnnualTax")
                        .WithOne("Car")
                        .HasForeignKey("WebPostgreSQL.Models.Car", "AnnualTaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebPostgreSQL.Models.Violator", "Violator")
                        .WithMany("Cars")
                        .HasForeignKey("ViolatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnnualTax");

                    b.Navigation("Violator");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Violation", b =>
                {
                    b.HasOne("WebPostgreSQL.Models.AnnualTax", "AnnualTax")
                        .WithMany()
                        .HasForeignKey("AnnualTaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebPostgreSQL.Models.Officer", "IssueOfficer")
                        .WithMany("Violations")
                        .HasForeignKey("IssueOfficerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebPostgreSQL.Models.Car", "IssuedCar")
                        .WithMany("Violations")
                        .HasForeignKey("IssuedCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebPostgreSQL.Models.Payment", "Payment")
                        .WithOne("Violation")
                        .HasForeignKey("WebPostgreSQL.Models.Violation", "PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnnualTax");

                    b.Navigation("IssueOfficer");

                    b.Navigation("IssuedCar");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.AnnualTax", b =>
                {
                    b.Navigation("Car")
                        .IsRequired();
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Car", b =>
                {
                    b.Navigation("Violations");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Officer", b =>
                {
                    b.Navigation("Violations");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Payment", b =>
                {
                    b.Navigation("Violation")
                        .IsRequired();
                });

            modelBuilder.Entity("WebPostgreSQL.Models.Violator", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
