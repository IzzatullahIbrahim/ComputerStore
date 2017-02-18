using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ComputerStore.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adapter = table.Column<string>(nullable: true),
                    Audio = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true),
                    Bluetooth = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Dimension = table.Column<string>(nullable: true),
                    Display = table.Column<decimal>(nullable: false),
                    Ethernet = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    IOInput1 = table.Column<string>(nullable: true),
                    IOInput2 = table.Column<string>(nullable: true),
                    IOInput3 = table.Column<string>(nullable: true),
                    IOInput4 = table.Column<string>(nullable: true),
                    IOInput5 = table.Column<string>(nullable: true),
                    IOInput6 = table.Column<string>(nullable: true),
                    IOInput7 = table.Column<string>(nullable: true),
                    IOInput8 = table.Column<string>(nullable: true),
                    Memory = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Motherboard = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    Security1 = table.Column<string>(nullable: true),
                    Security2 = table.Column<string>(nullable: true),
                    Storage1 = table.Column<string>(nullable: true),
                    Storage2 = table.Column<string>(nullable: true),
                    Storage3 = table.Column<string>(nullable: true),
                    Storage4 = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Wireless = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptops");
        }
    }
}
