using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerStore.Data.Migrations
{
    public partial class ChangeGalleryDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "GalleryDisplay",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryGPU",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryMemory",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryOS",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryProcessor",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryStorage",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GalleryWireless",
                table: "Laptops",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Laptops",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GalleryDisplay",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryGPU",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryMemory",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryOS",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryProcessor",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryStorage",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "GalleryWireless",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Laptops");

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
        }
    }
}
