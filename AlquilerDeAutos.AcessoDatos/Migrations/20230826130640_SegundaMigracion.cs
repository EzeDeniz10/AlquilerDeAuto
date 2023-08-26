using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquilerDeAutos.AcessoDatos.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoCombustible",
                table: "TipoCombustible");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reserva",
                table: "Reserva");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pago",
                table: "Pago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormaDePago",
                table: "FormaDePago");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "TipoCombustible",
                newName: "tipoCombustibles");

            migrationBuilder.RenameTable(
                name: "Reserva",
                newName: "Reservas");

            migrationBuilder.RenameTable(
                name: "Pago",
                newName: "Pagos");

            migrationBuilder.RenameTable(
                name: "FormaDePago",
                newName: "FormaDePagos");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Usuarios",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidad",
                table: "Usuarios",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IdVehiculo",
                table: "Reservas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ReservaIdReservas",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipoCombustibles",
                table: "tipoCombustibles",
                column: "IdCombustible");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservas",
                table: "Reservas",
                column: "IdReservas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagos",
                table: "Pagos",
                column: "IdPago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormaDePagos",
                table: "FormaDePagos",
                column: "IdFormaDePago");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_IdTipoCombustible",
                table: "vehiculos",
                column: "IdTipoCombustible");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IdUsuarios",
                table: "Reservas",
                column: "IdUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IdVehiculo",
                table: "Reservas",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdFormaDePago",
                table: "Pagos",
                column: "IdFormaDePago");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ReservaIdReservas",
                table: "Pagos",
                column: "ReservaIdReservas");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_FormaDePagos_IdFormaDePago",
                table: "Pagos",
                column: "IdFormaDePago",
                principalTable: "FormaDePagos",
                principalColumn: "IdFormaDePago",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Reservas_ReservaIdReservas",
                table: "Pagos",
                column: "ReservaIdReservas",
                principalTable: "Reservas",
                principalColumn: "IdReservas",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Usuarios_IdUsuarios",
                table: "Reservas",
                column: "IdUsuarios",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_vehiculos_IdVehiculo",
                table: "Reservas",
                column: "IdVehiculo",
                principalTable: "vehiculos",
                principalColumn: "IdVehiculo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_tipoCombustibles_IdTipoCombustible",
                table: "vehiculos",
                column: "IdTipoCombustible",
                principalTable: "tipoCombustibles",
                principalColumn: "IdCombustible",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_FormaDePagos_IdFormaDePago",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Reservas_ReservaIdReservas",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Usuarios_IdUsuarios",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_vehiculos_IdVehiculo",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_tipoCombustibles_IdTipoCombustible",
                table: "vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_vehiculos_IdTipoCombustible",
                table: "vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipoCombustibles",
                table: "tipoCombustibles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservas",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_IdUsuarios",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_IdVehiculo",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagos",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_IdFormaDePago",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_ReservaIdReservas",
                table: "Pagos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormaDePagos",
                table: "FormaDePagos");

            migrationBuilder.DropColumn(
                name: "ReservaIdReservas",
                table: "Pagos");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "tipoCombustibles",
                newName: "TipoCombustible");

            migrationBuilder.RenameTable(
                name: "Reservas",
                newName: "Reserva");

            migrationBuilder.RenameTable(
                name: "Pagos",
                newName: "Pago");

            migrationBuilder.RenameTable(
                name: "FormaDePagos",
                newName: "FormaDePago");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Usuario",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidad",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "IdVehiculo",
                table: "Reserva",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoCombustible",
                table: "TipoCombustible",
                column: "IdCombustible");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reserva",
                table: "Reserva",
                column: "IdReservas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pago",
                table: "Pago",
                column: "IdPago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormaDePago",
                table: "FormaDePago",
                column: "IdFormaDePago");
        }
    }
}
