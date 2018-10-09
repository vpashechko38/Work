using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WorkApiCore20.Migrations
{
    public partial class BigUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Organization",
                table: "Users",
                newName: "UnitCodePasport");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "SeriesAndNumberPasport");

            migrationBuilder.RenameColumn(
                name: "ApiKey",
                table: "Users",
                newName: "SeriesAndNumberCertificate");

            migrationBuilder.AddColumn<string>(
                name: "ActingBasis",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActualAddress",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BIK",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CheckingAccount",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CorrespondentAccount",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfIssueCertificate",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfIssuePasport",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Fio",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INN",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuedByPasport",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KPP",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LegalAddress",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameOrganization",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OGRN",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OGRNIP",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeClient",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActingBasis",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ActualAddress",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BIK",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CheckingAccount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CorrespondentAccount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateOfIssueCertificate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateOfIssuePasport",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Fio",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "INN",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IssuedByPasport",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "KPP",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LegalAddress",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NameOrganization",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OGRN",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OGRNIP",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TypeClient",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UnitCodePasport",
                table: "Users",
                newName: "Organization");

            migrationBuilder.RenameColumn(
                name: "SeriesAndNumberPasport",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SeriesAndNumberCertificate",
                table: "Users",
                newName: "ApiKey");
        }
    }
}
