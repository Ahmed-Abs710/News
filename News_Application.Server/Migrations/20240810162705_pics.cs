using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace News_Application.Server.Migrations
{
    /// <inheritdoc />
    public partial class pics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsPics");

            migrationBuilder.AddColumn<string>(
                name: "PicPath",
                table: "articles",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicPath",
                table: "articles");

            migrationBuilder.CreateTable(
                name: "NewsPics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsPics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsPics_articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "articles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewsPics_ArticleId",
                table: "NewsPics",
                column: "ArticleId",
                unique: true);
        }
    }
}
