using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoCursos.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDurationInHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DurationInHours",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationInHours",
                table: "Courses");
        }
    }
}
