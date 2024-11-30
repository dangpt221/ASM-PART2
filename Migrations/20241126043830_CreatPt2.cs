using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PTCar.Migrations
{
    /// <inheritdoc />
    public partial class CreatPt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_products_ProductID",
                table: "inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_customers_CustomerID",
                table: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_Staffs_StaffID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_customers_CustomerID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Suppliers_SupplierID",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StaffID",
                table: "orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "invoices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "inventories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_inventories_products_ProductID",
                table: "inventories",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_customers_CustomerID",
                table: "invoices",
                column: "CustomerID",
                principalTable: "customers",
                principalColumn: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Staffs_StaffID",
                table: "orders",
                column: "StaffID",
                principalTable: "Staffs",
                principalColumn: "StaffID");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_customers_CustomerID",
                table: "orders",
                column: "CustomerID",
                principalTable: "customers",
                principalColumn: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Suppliers_SupplierID",
                table: "products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_products_ProductID",
                table: "inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_customers_CustomerID",
                table: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_Staffs_StaffID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_customers_CustomerID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Suppliers_SupplierID",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StaffID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "invoices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "inventories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_inventories_products_ProductID",
                table: "inventories",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_customers_CustomerID",
                table: "invoices",
                column: "CustomerID",
                principalTable: "customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Staffs_StaffID",
                table: "orders",
                column: "StaffID",
                principalTable: "Staffs",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_customers_CustomerID",
                table: "orders",
                column: "CustomerID",
                principalTable: "customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Suppliers_SupplierID",
                table: "products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
