using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoCursos.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoNomeCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Courses",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Courses",
                newName: "CreateAt");
        }
    }
}
