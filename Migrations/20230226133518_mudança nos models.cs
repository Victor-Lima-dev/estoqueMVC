using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estoqueMVC.Migrations
{
    /// <inheritdoc />
    public partial class mudançanosmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DataValidade",
                table: "Produtos");

            migrationBuilder.AddColumn<DateTime>(
                name: "Entrada",
                table: "ItensEstoque",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Validade",
                table: "ItensEstoque",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Entrada",
                table: "ItensEstoque");

            migrationBuilder.DropColumn(
                name: "Validade",
                table: "ItensEstoque");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Produtos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataValidade",
                table: "Produtos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
