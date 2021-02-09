using Microsoft.EntityFrameworkCore.Migrations;

namespace ngWebAPI.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Users__pub_id__607251E5",
                table: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Publisher_pub_id",
                table: "User",
                column: "pub_id",
                principalTable: "Publisher",
                principalColumn: "pub_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Publisher_pub_id",
                table: "User");

            migrationBuilder.AddForeignKey(
                name: "FK__Users__pub_id__607251E5",
                table: "User",
                column: "pub_id",
                principalTable: "Publisher",
                principalColumn: "pub_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
