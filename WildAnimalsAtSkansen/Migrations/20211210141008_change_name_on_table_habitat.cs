using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WildAnimalsAtSkansen.Migrations
{
    public partial class change_name_on_table_habitat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Habitats_HabitatId",
                table: "Animal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitats",
                table: "Habitats");

            migrationBuilder.RenameTable(
                name: "Habitats",
                newName: "Habitat");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "AnimalType",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true,
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Animal",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true,
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Habitat",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true,
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitat",
                table: "Habitat",
                column: "HabitatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Habitat_HabitatId",
                table: "Animal",
                column: "HabitatId",
                principalTable: "Habitat",
                principalColumn: "HabitatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Habitat_HabitatId",
                table: "Animal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitat",
                table: "Habitat");

            migrationBuilder.RenameTable(
                name: "Habitat",
                newName: "Habitats");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "AnimalType",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Animal",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Habitats",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitats",
                table: "Habitats",
                column: "HabitatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Habitats_HabitatId",
                table: "Animal",
                column: "HabitatId",
                principalTable: "Habitats",
                principalColumn: "HabitatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
