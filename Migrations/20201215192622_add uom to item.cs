using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DMSOShopping.Migrations
{
    public partial class adduomtoitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_UOMs_UOMId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_UOMId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "UOMId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "UOM",
                table: "Items");

            migrationBuilder.AddColumn<Guid>(
                name: "UOMId",
                table: "Items",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Items_UOMId",
                table: "Items",
                column: "UOMId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_UOMs_UOMId",
                table: "Items",
                column: "UOMId",
                principalTable: "UOMs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_UOMs_UOMId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_UOMId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UOMId",
                table: "Items");

            migrationBuilder.AddColumn<Guid>(
                name: "UOMId",
                table: "OrderDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UOM",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_UOMId",
                table: "OrderDetails",
                column: "UOMId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_UOMs_UOMId",
                table: "OrderDetails",
                column: "UOMId",
                principalTable: "UOMs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
