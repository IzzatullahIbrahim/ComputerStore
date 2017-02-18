using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerStore.Data.Migrations
{
    public partial class AddQuantityAnd6GalleryDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GalleryDescription1",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryDescription2",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryDescription3",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryDescription4",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryDescription5",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryDescription6",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Laptops",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GalleryDescription1",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryDescription2",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryDescription3",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryDescription4",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryDescription5",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryDescription6",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Laptops");
        }
    }
}
