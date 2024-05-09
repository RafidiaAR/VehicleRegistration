using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleRegistrationBE.Migrations.TransactionDBData
{
    public partial class CreateTableBPKB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TR_BPKB",
                columns: table => new
                {
                    agreement_number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    bpkb_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    branch_id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    bpkb_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    faktur_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    faktur_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    location_id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    police_no = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    bpkb_date_in = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_BPKB", x => x.agreement_number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TR_BPKB");
        }
    }
}
