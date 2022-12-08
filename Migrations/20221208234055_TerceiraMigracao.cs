using Microsoft.EntityFrameworkCore.Migrations;

namespace IMC_aplication.Migrations
{
    public partial class TerceiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imcs_Usuarios_UsuarioId",
                table: "Imcs");

            migrationBuilder.DropIndex(
                name: "IX_Imcs_UsuarioId",
                table: "Imcs");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Imcs");
        }
    }
}
