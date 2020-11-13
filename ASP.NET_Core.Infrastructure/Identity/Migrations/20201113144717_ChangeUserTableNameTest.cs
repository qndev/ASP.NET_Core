using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core.Infrastructure.Identity.Migrations
{
    public partial class ChangeUserTableNameTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserClaimsTest_ElcUsersTest_UserId",
                table: "ElcUserClaimsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserClaimsTest_ElcUsersTest_UserId1",
                table: "ElcUserClaimsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserLoginsTest_ElcUsersTest_UserId",
                table: "ElcUserLoginsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserLoginsTest_ElcUsersTest_UserId1",
                table: "ElcUserLoginsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserRolesTest_ElcUsersTest_UserId",
                table: "ElcUserRolesTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserTokensTest_ElcUsersTest_UserId",
                table: "ElcUserTokensTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserTokensTest_ElcUsersTest_UserId1",
                table: "ElcUserTokensTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUsersTest",
                table: "ElcUsersTest");

            migrationBuilder.RenameTable(
                name: "ElcUsersTest",
                newName: "AspNetUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserClaimsTest_AspNetUsers_UserId",
                table: "ElcUserClaimsTest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserClaimsTest_AspNetUsers_UserId1",
                table: "ElcUserClaimsTest",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserLoginsTest_AspNetUsers_UserId",
                table: "ElcUserLoginsTest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserLoginsTest_AspNetUsers_UserId1",
                table: "ElcUserLoginsTest",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserRolesTest_AspNetUsers_UserId",
                table: "ElcUserRolesTest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserTokensTest_AspNetUsers_UserId",
                table: "ElcUserTokensTest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserTokensTest_AspNetUsers_UserId1",
                table: "ElcUserTokensTest",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserClaimsTest_AspNetUsers_UserId",
                table: "ElcUserClaimsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserClaimsTest_AspNetUsers_UserId1",
                table: "ElcUserClaimsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserLoginsTest_AspNetUsers_UserId",
                table: "ElcUserLoginsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserLoginsTest_AspNetUsers_UserId1",
                table: "ElcUserLoginsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserRolesTest_AspNetUsers_UserId",
                table: "ElcUserRolesTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserTokensTest_AspNetUsers_UserId",
                table: "ElcUserTokensTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserTokensTest_AspNetUsers_UserId1",
                table: "ElcUserTokensTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "ElcUsersTest");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUsersTest",
                table: "ElcUsersTest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserClaimsTest_ElcUsersTest_UserId",
                table: "ElcUserClaimsTest",
                column: "UserId",
                principalTable: "ElcUsersTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserClaimsTest_ElcUsersTest_UserId1",
                table: "ElcUserClaimsTest",
                column: "UserId1",
                principalTable: "ElcUsersTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserLoginsTest_ElcUsersTest_UserId",
                table: "ElcUserLoginsTest",
                column: "UserId",
                principalTable: "ElcUsersTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserLoginsTest_ElcUsersTest_UserId1",
                table: "ElcUserLoginsTest",
                column: "UserId1",
                principalTable: "ElcUsersTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserRolesTest_ElcUsersTest_UserId",
                table: "ElcUserRolesTest",
                column: "UserId",
                principalTable: "ElcUsersTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserTokensTest_ElcUsersTest_UserId",
                table: "ElcUserTokensTest",
                column: "UserId",
                principalTable: "ElcUsersTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserTokensTest_ElcUsersTest_UserId1",
                table: "ElcUserTokensTest",
                column: "UserId1",
                principalTable: "ElcUsersTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
