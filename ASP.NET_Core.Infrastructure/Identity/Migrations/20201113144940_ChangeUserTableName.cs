using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core.Infrastructure.Identity.Migrations
{
    public partial class ChangeUserTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "ElcUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUsers",
                table: "ElcUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserClaimsTest_ElcUsers_UserId",
                table: "ElcUserClaimsTest",
                column: "UserId",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserClaimsTest_ElcUsers_UserId1",
                table: "ElcUserClaimsTest",
                column: "UserId1",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserLoginsTest_ElcUsers_UserId",
                table: "ElcUserLoginsTest",
                column: "UserId",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserLoginsTest_ElcUsers_UserId1",
                table: "ElcUserLoginsTest",
                column: "UserId1",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserRolesTest_ElcUsers_UserId",
                table: "ElcUserRolesTest",
                column: "UserId",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserTokensTest_ElcUsers_UserId",
                table: "ElcUserTokensTest",
                column: "UserId",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserTokensTest_ElcUsers_UserId1",
                table: "ElcUserTokensTest",
                column: "UserId1",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserClaimsTest_ElcUsers_UserId",
                table: "ElcUserClaimsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserClaimsTest_ElcUsers_UserId1",
                table: "ElcUserClaimsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserLoginsTest_ElcUsers_UserId",
                table: "ElcUserLoginsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserLoginsTest_ElcUsers_UserId1",
                table: "ElcUserLoginsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserRolesTest_ElcUsers_UserId",
                table: "ElcUserRolesTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserTokensTest_ElcUsers_UserId",
                table: "ElcUserTokensTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserTokensTest_ElcUsers_UserId1",
                table: "ElcUserTokensTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUsers",
                table: "ElcUsers");

            migrationBuilder.RenameTable(
                name: "ElcUsers",
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
    }
}
