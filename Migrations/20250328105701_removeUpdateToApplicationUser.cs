using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ava.Shared.Migrations
{
    /// <inheritdoc />
    public partial class removeUpdateToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TravelPolicyId",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TravelPolicyId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);
        }
    }
}
