﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JesusPortilla.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_GeneroId",
                table: "Usuarios",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Genero_GeneroId",
                table: "Usuarios",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Genero_GeneroId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_GeneroId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Usuarios");
        }
    }
}
