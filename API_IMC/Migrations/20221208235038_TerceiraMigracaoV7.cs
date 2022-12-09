using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IMC_aplication.Migrations
{
    public partial class TerceiraMigracaoV7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imcs_Usuarios_UsuarioId",
                table: "Imcs");

            migrationBuilder.DropIndex(
                name: "IX_Imcs_UsuarioId",
                table: "Imcs");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Imcs");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Imcs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Imcs",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Imcs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Imcs_UsuarioId",
                table: "Imcs",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imcs_Usuarios_UsuarioId",
                table: "Imcs",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
