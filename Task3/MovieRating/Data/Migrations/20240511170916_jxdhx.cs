using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRating.Migrations
{
    /// <inheritdoc />
    public partial class jxdhx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsersRated",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersRated",
                table: "Movie");
        }
    }
}
