using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PTCar.Migrations
{
    /// <inheritdoc />
    public partial class CreatePTCAR2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "InventoryQuantity",
                table: "products",
                newName: "Quantity");

            migrationBuilder.AddColumn<string>(
                name: "OrderName",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StaffID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_orders_StaffID",
                table: "orders",
                column: "StaffID");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Staffs_StaffID",
                table: "orders",
                column: "StaffID",
                principalTable: "Staffs",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_Staffs_StaffID",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_StaffID",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "OrderName",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "products",
                newName: "InventoryQuantity");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
