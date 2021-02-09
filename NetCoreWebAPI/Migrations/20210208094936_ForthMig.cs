using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ngWebAPI.Migrations
{
    public partial class ForthMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Users__job_id__114A936A",
                table: "User");

            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_job_id",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "pub_id",
                table: "Users",
                newName: "PubId");

            migrationBuilder.RenameColumn(
                name: "middle_name",
                table: "Users",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "job_level",
                table: "Users",
                newName: "JobLevel");

            migrationBuilder.RenameColumn(
                name: "job_id",
                table: "Users",
                newName: "JobId");

            migrationBuilder.RenameColumn(
                name: "hire_date",
                table: "Users",
                newName: "HireDate");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<byte>(
                name: "JobLevel",
                table: "Users",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "((10))");

            migrationBuilder.AlterColumn<short>(
                name: "JobId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "PubId",
                table: "User",
                newName: "pub_id");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "User",
                newName: "middle_name");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "User",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "JobLevel",
                table: "User",
                newName: "job_level");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "User",
                newName: "job_id");

            migrationBuilder.RenameColumn(
                name: "HireDate",
                table: "User",
                newName: "hire_date");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "User",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "User",
                newName: "user_id");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "User",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "User",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "User",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "job_level",
                table: "User",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "((10))",
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "job_id",
                table: "User",
                type: "smallint",
                nullable: false,
                defaultValueSql: "((1))",
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<DateTime>(
                name: "hire_date",
                table: "User",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "User",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "User",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_id",
                table: "User",
                column: "user_id")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    author_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    email_address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    first_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    last_name = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    phone = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: false, defaultValueSql: "('UNKNOWN')"),
                    state = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    zip = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.author_id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    advance = table.Column<decimal>(type: "money", nullable: true),
                    notes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    price = table.Column<decimal>(type: "money", nullable: true),
                    pub_id = table.Column<int>(type: "int", nullable: false),
                    published_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    royalty = table.Column<int>(type: "int", nullable: true),
                    title = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    type = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: false, defaultValueSql: "('UNDECIDED')"),
                    ytd_sales = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.book_id);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    job_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_desc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('New Position - title not formalized yet')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.job_id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    store_id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    store_address = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    store_name = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    zip = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.store_id);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    author_id = table.Column<int>(type: "int", nullable: false),
                    book_id = table.Column<int>(type: "int", nullable: false),
                    author_order = table.Column<byte>(type: "tinyint", nullable: true),
                    royality_percentage = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => new { x.author_id, x.book_id });
                    table.ForeignKey(
                        name: "FK__BookAutho__autho__43D61337",
                        column: x => x.author_id,
                        principalTable: "Author",
                        principalColumn: "author_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__BookAutho__book___42E1EEFE",
                        column: x => x.book_id,
                        principalTable: "Book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    sale_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_id = table.Column<int>(type: "int", nullable: false),
                    order_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    order_num = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    pay_terms = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    quantity = table.Column<short>(type: "smallint", nullable: false),
                    store_id = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.sale_id);
                    table.ForeignKey(
                        name: "FK__Sale2__book_id__756D6ECB",
                        column: x => x.book_id,
                        principalTable: "Book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Sale2__store_id__76619304",
                        column: x => x.store_id,
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_job_id",
                table: "User",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_book_id",
                table: "BookAuthor",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_book_id",
                table: "Sale",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_store_id",
                table: "Sale",
                column: "store_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Users__job_id__114A936A",
                table: "User",
                column: "job_id",
                principalTable: "Job",
                principalColumn: "job_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
