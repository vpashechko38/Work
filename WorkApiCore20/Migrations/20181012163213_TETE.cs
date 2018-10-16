using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WorkApiCore20.Migrations
{
    public partial class TETE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KeyLicense = table.Column<string>(nullable: true),
                    LifeTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActingBasis = table.Column<string>(nullable: true),
                    ActualAddress = table.Column<string>(nullable: true),
                    BIK = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    CheckingAccount = table.Column<string>(nullable: true),
                    CorrespondentAccount = table.Column<string>(nullable: true),
                    DateOfIssueCertificate = table.Column<string>(nullable: true),
                    DateOfIssuePassport = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Fio = table.Column<string>(nullable: true),
                    INN = table.Column<string>(nullable: true),
                    IssuedByPasport = table.Column<string>(nullable: true),
                    KPP = table.Column<string>(nullable: true),
                    LegalAddress = table.Column<string>(nullable: true),
                    NameOrganization = table.Column<string>(nullable: true),
                    OGRN = table.Column<string>(nullable: true),
                    OGRNIP = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    SeriesAndNumberCertificate = table.Column<string>(nullable: true),
                    SeriesAndNumberPassport = table.Column<string>(nullable: true),
                    Success = table.Column<bool>(nullable: false),
                    TypeClient = table.Column<int>(nullable: false),
                    UnitCodePasport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamePosition = table.Column<string>(nullable: true),
                    PricePosition = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActualVersion = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Versions");
        }
    }
}
