using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTeam.Data.Migrations
{
    /// <inheritdoc />
    public partial class ad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(200)", maxLength: 200, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(200)", maxLength: 200, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BlockedTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BlockedBy = table.Column<int>(type: "int", nullable: true),
                    AppRoleId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "Address", "AppRoleId", "Avatar", "BlockedBy", "BlockedTo", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Email", "FullName", "PasswordHash", "PasswordSalt", "PhoneNumber1", "PhoneNumber2", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[] { 1, "Thành phố Hồ Chí Minh", -1, null, null, null, -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin_test@gmail.com", "Nguyen ProVip123", new byte[] { 48, 226, 96, 96, 76, 33, 214, 6, 74, 243, 83, 180, 197, 163, 246, 179, 156, 220, 166, 136, 166, 232, 55, 26, 17, 11, 227, 231, 48, 210, 176, 78, 126, 202, 227, 98, 193, 46, 102, 2, 23, 157, 38, 45, 155, 53, 129, 129, 153, 77, 44, 125, 162, 45, 57, 173, 138, 174, 232, 233, 89, 138, 191, 34 }, new byte[] { 8, 192, 75, 70, 93, 207, 45, 92, 60, 234, 110, 72, 167, 99, 25, 186, 161, 227, 180, 42, 80, 30, 117, 100, 124, 169, 249, 11, 69, 182, 43, 192, 56, 48, 72, 236, 9, 194, 132, 42, 81, 22, 205, 164, 112, 150, 148, 252, 111, 128, 78, 210, 165, 41, 31, 90, 33, 114, 49, 42, 51, 62, 108, 2, 212, 52, 247, 130, 46, 189, 214, 73, 14, 109, 150, 29, 249, 149, 239, 31, 14, 215, 75, 38, 12, 169, 12, 238, 167, 16, 29, 206, 138, 138, 223, 198, 144, 184, 177, 85, 235, 25, 87, 149, 200, 54, 130, 156, 1, 15, 143, 115, 73, 30, 199, 9, 77, 14, 21, 60, 162, 90, 15, 157, 214, 102, 13, 124 }, "0939002144", "0939002144", -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Email",
                table: "AppUser",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Username",
                table: "AppUser",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUser");
        }
    }
}
