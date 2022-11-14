using Microsoft.EntityFrameworkCore.Migrations;

namespace quiz_api.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IamgeName",
                table: "Questions",
                newName: "ImageName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Questions",
                newName: "IamgeName");
        }
    }
}
