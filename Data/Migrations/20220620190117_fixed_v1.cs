using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class fixed_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 827, DateTimeKind.Local).AddTicks(1385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 773, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductStocks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(8871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 773, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(7224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductDocuments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(7940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 773, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(6446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(5663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PersonnelSales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(4698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Personnels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(3125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PersonnelDepartments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(3856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "OrderProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(2470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(4382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Maillings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(3491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(1928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(1249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 823, DateTimeKind.Local).AddTicks(8632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(2720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsCompany = table.Column<bool>(type: "bit", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 825, DateTimeKind.Local).AddTicks(3292)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberOrderHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 825, DateTimeKind.Local).AddTicks(8741)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberOrderHistory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Member_Id",
                table: "Member",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MemberOrderHistory_Id",
                table: "MemberOrderHistory",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "MemberOrderHistory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 773, DateTimeKind.Local).AddTicks(2865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 827, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductStocks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 773, DateTimeKind.Local).AddTicks(936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(7931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductDocuments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 773, DateTimeKind.Local).AddTicks(4),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(6455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(4584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PersonnelSales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(2877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Personnels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(1295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PersonnelDepartments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(2087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(9598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "OrderProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 772, DateTimeKind.Local).AddTicks(631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 826, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(8789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Maillings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(7956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(4512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(3813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(2868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 823, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 19, 9, 17, 771, DateTimeKind.Local).AddTicks(7148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 20, 22, 1, 17, 824, DateTimeKind.Local).AddTicks(2720));
        }
    }
}
