using Microsoft.EntityFrameworkCore.Migrations;

namespace ngWebAPI.Migrations
{
    public partial class ThirdMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Book__pub_id__6166761E",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Publisher_pub_id",
                table: "User");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_User_pub_id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Book_pub_id",
                table: "Book");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    pub_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    country = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValueSql: "('USA')"),
                    publisher_name = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    state = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Publishe__2515F222DDC013AD", x => x.pub_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_pub_id",
                table: "User",
                column: "pub_id");

            migrationBuilder.CreateIndex(
                name: "IX_Book_pub_id",
                table: "Book",
                column: "pub_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Book__pub_id__6166761E",
                table: "Book",
                column: "pub_id",
                principalTable: "Publisher",
                principalColumn: "pub_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Publisher_pub_id",
                table: "User",
                column: "pub_id",
                principalTable: "Publisher",
                principalColumn: "pub_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
