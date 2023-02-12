using API_Valorant_NET.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIValorantNET.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Agents.Ability[]>(
                name: "abilities",
                table: "Agents",
                type: "jsonb",
                nullable: false,
                defaultValue: new Agents.Ability[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "abilities",
                table: "Agents");
        }
    }
}
