using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2526_2221050694_BaiThi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TinhThanhs",
                columns: table => new
                {
                    MaTinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanhs", x => x.MaTinh);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TinhThanhs");
        }
    }
}
