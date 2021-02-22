using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class UpdatePaisToCiudad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatosClimaticos_Ciudades_CiudadId",
                table: "DatosClimaticos");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosClimaticos_Paises_PaisId",
                table: "DatosClimaticos");

            migrationBuilder.DropIndex(
                name: "IX_DatosClimaticos_PaisId",
                table: "DatosClimaticos");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "DatosClimaticos");

            migrationBuilder.AlterColumn<int>(
                name: "CiudadId",
                table: "DatosClimaticos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosClimaticos_Ciudades_CiudadId",
                table: "DatosClimaticos",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatosClimaticos_Ciudades_CiudadId",
                table: "DatosClimaticos");

            migrationBuilder.AlterColumn<int>(
                name: "CiudadId",
                table: "DatosClimaticos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "DatosClimaticos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DatosClimaticos_PaisId",
                table: "DatosClimaticos",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosClimaticos_Ciudades_CiudadId",
                table: "DatosClimaticos",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosClimaticos_Paises_PaisId",
                table: "DatosClimaticos",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
