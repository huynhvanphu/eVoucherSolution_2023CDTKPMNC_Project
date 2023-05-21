using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eVoucher_BUS.Migrations
{
    /// <inheritdoc />
    public partial class editAppUserclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Customers_CustomerID",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Partners_PartnerID",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Staffs_StaffID",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_UserID",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Partners_UserID",
                table: "Partners");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_CustomerID",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_PartnerID",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_StaffID",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "PartnerID",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "AppUsers");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserID",
                table: "Staffs",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Partners_UserID",
                table: "Partners",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserID",
                table: "Customers",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Staffs_UserID",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Partners_UserID",
                table: "Partners");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserID",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartnerID",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffID",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserID",
                table: "Staffs",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Partners_UserID",
                table: "Partners",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserID",
                table: "Customers",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_CustomerID",
                table: "AppUsers",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_PartnerID",
                table: "AppUsers",
                column: "PartnerID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_StaffID",
                table: "AppUsers",
                column: "StaffID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Customers_CustomerID",
                table: "AppUsers",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Partners_PartnerID",
                table: "AppUsers",
                column: "PartnerID",
                principalTable: "Partners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Staffs_StaffID",
                table: "AppUsers",
                column: "StaffID",
                principalTable: "Staffs",
                principalColumn: "Id");
        }
    }
}
