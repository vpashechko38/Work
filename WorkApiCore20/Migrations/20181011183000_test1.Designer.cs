﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WorkApiCore20.Models;

namespace WorkApiCore20.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181011183000_test1")]
    partial class test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("WorkApiCore20.Models.LicenseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KeyLicense");

                    b.Property<DateTime>("LifeTime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("WorkApiCore20.Models.PartnerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActingBasis");

                    b.Property<string>("ActualAddress");

                    b.Property<string>("BIK");

                    b.Property<string>("BankName");

                    b.Property<string>("CheckingAccount");

                    b.Property<string>("CorrespondentAccount");

                    b.Property<string>("DateOfIssueCertificate");

                    b.Property<DateTime>("DateOfIssuePasport");

                    b.Property<string>("Email");

                    b.Property<string>("Fio");

                    b.Property<string>("INN");

                    b.Property<string>("IssuedByPasport");

                    b.Property<string>("KPP");

                    b.Property<string>("LegalAddress");

                    b.Property<string>("NameOrganization");

                    b.Property<string>("OGRN");

                    b.Property<string>("OGRNIP");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Position");

                    b.Property<string>("SeriesAndNumberCertificate");

                    b.Property<string>("SeriesAndNumberPasport");

                    b.Property<bool>("Success");

                    b.Property<int>("TypeClient");

                    b.Property<string>("UnitCodePasport");

                    b.HasKey("Id");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("WorkApiCore20.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NamePosition");

                    b.Property<string>("PricePosition");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });
#pragma warning restore 612, 618
        }
    }
}
