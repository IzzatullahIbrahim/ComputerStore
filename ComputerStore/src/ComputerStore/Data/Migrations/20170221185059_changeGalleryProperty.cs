using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerStore.Data.Migrations
{
    public partial class changeGalleryProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GalleryOS",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryWireless",
                table: "Laptops");

            migrationBuilder.AddColumn<string>(
                name: "GalleryBatteryDimension",
                table: "Laptops",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GalleryBatteryDimension",
                table: "Laptops");

            migrationBuilder.AddColumn<string>(
                name: "GalleryOS",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryWireless",
                table: "Laptops",
                nullable: true);
        }
    }
}
