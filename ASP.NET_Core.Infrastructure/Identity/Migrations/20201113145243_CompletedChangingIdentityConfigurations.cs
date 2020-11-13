using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core.Infrastructure.Identity.Migrations
{
    public partial class CompletedChangingIdentityConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElcRoleClaimsTest_ElcRolesTest_RoleId",
                table: "ElcRoleClaimsTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcRoleClaimsTest_ElcRolesTest_RoleId1",
                table: "ElcRoleClaimsTest");

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
                name: "FK_ElcUserRolesTest_ElcRolesTest_RoleId",
                table: "ElcUserRolesTest");

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
                name: "PK_ElcUserTokensTest",
                table: "ElcUserTokensTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUserRolesTest",
                table: "ElcUserRolesTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUserLoginsTest",
                table: "ElcUserLoginsTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUserClaimsTest",
                table: "ElcUserClaimsTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcRolesTest",
                table: "ElcRolesTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcRoleClaimsTest",
                table: "ElcRoleClaimsTest");

            migrationBuilder.RenameTable(
                name: "ElcUserTokensTest",
                newName: "ElcUserTokens");

            migrationBuilder.RenameTable(
                name: "ElcUserRolesTest",
                newName: "ElcUserRoles");

            migrationBuilder.RenameTable(
                name: "ElcUserLoginsTest",
                newName: "ElcUserLogins");

            migrationBuilder.RenameTable(
                name: "ElcUserClaimsTest",
                newName: "ElcUserClaims");

            migrationBuilder.RenameTable(
                name: "ElcRolesTest",
                newName: "ElcRoles");

            migrationBuilder.RenameTable(
                name: "ElcRoleClaimsTest",
                newName: "ElcRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserTokensTest_UserId1",
                table: "ElcUserTokens",
                newName: "IX_ElcUserTokens_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserRolesTest_RoleId",
                table: "ElcUserRoles",
                newName: "IX_ElcUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserLoginsTest_UserId1",
                table: "ElcUserLogins",
                newName: "IX_ElcUserLogins_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserLoginsTest_UserId",
                table: "ElcUserLogins",
                newName: "IX_ElcUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserClaimsTest_UserId1",
                table: "ElcUserClaims",
                newName: "IX_ElcUserClaims_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserClaimsTest_UserId",
                table: "ElcUserClaims",
                newName: "IX_ElcUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ElcRoleClaimsTest_RoleId1",
                table: "ElcRoleClaims",
                newName: "IX_ElcRoleClaims_RoleId1");

            migrationBuilder.RenameIndex(
                name: "IX_ElcRoleClaimsTest_RoleId",
                table: "ElcRoleClaims",
                newName: "IX_ElcRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserTokens",
                table: "ElcUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserRoles",
                table: "ElcUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserLogins",
                table: "ElcUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserClaims",
                table: "ElcUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcRoles",
                table: "ElcRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcRoleClaims",
                table: "ElcRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ElcRoleClaims_ElcRoles_RoleId",
                table: "ElcRoleClaims",
                column: "RoleId",
                principalTable: "ElcRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcRoleClaims_ElcRoles_RoleId1",
                table: "ElcRoleClaims",
                column: "RoleId1",
                principalTable: "ElcRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserClaims_ElcUsers_UserId",
                table: "ElcUserClaims",
                column: "UserId",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserClaims_ElcUsers_UserId1",
                table: "ElcUserClaims",
                column: "UserId1",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserLogins_ElcUsers_UserId",
                table: "ElcUserLogins",
                column: "UserId",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserLogins_ElcUsers_UserId1",
                table: "ElcUserLogins",
                column: "UserId1",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserRoles_ElcRoles_RoleId",
                table: "ElcUserRoles",
                column: "RoleId",
                principalTable: "ElcRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserRoles_ElcUsers_UserId",
                table: "ElcUserRoles",
                column: "UserId",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserTokens_ElcUsers_UserId",
                table: "ElcUserTokens",
                column: "UserId",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserTokens_ElcUsers_UserId1",
                table: "ElcUserTokens",
                column: "UserId1",
                principalTable: "ElcUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElcRoleClaims_ElcRoles_RoleId",
                table: "ElcRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcRoleClaims_ElcRoles_RoleId1",
                table: "ElcRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserClaims_ElcUsers_UserId",
                table: "ElcUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserClaims_ElcUsers_UserId1",
                table: "ElcUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserLogins_ElcUsers_UserId",
                table: "ElcUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserLogins_ElcUsers_UserId1",
                table: "ElcUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserRoles_ElcRoles_RoleId",
                table: "ElcUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserRoles_ElcUsers_UserId",
                table: "ElcUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserTokens_ElcUsers_UserId",
                table: "ElcUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserTokens_ElcUsers_UserId1",
                table: "ElcUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUserTokens",
                table: "ElcUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUserRoles",
                table: "ElcUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUserLogins",
                table: "ElcUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUserClaims",
                table: "ElcUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcRoles",
                table: "ElcRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcRoleClaims",
                table: "ElcRoleClaims");

            migrationBuilder.RenameTable(
                name: "ElcUserTokens",
                newName: "ElcUserTokensTest");

            migrationBuilder.RenameTable(
                name: "ElcUserRoles",
                newName: "ElcUserRolesTest");

            migrationBuilder.RenameTable(
                name: "ElcUserLogins",
                newName: "ElcUserLoginsTest");

            migrationBuilder.RenameTable(
                name: "ElcUserClaims",
                newName: "ElcUserClaimsTest");

            migrationBuilder.RenameTable(
                name: "ElcRoles",
                newName: "ElcRolesTest");

            migrationBuilder.RenameTable(
                name: "ElcRoleClaims",
                newName: "ElcRoleClaimsTest");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserTokens_UserId1",
                table: "ElcUserTokensTest",
                newName: "IX_ElcUserTokensTest_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserRoles_RoleId",
                table: "ElcUserRolesTest",
                newName: "IX_ElcUserRolesTest_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserLogins_UserId1",
                table: "ElcUserLoginsTest",
                newName: "IX_ElcUserLoginsTest_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserLogins_UserId",
                table: "ElcUserLoginsTest",
                newName: "IX_ElcUserLoginsTest_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserClaims_UserId1",
                table: "ElcUserClaimsTest",
                newName: "IX_ElcUserClaimsTest_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserClaims_UserId",
                table: "ElcUserClaimsTest",
                newName: "IX_ElcUserClaimsTest_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ElcRoleClaims_RoleId1",
                table: "ElcRoleClaimsTest",
                newName: "IX_ElcRoleClaimsTest_RoleId1");

            migrationBuilder.RenameIndex(
                name: "IX_ElcRoleClaims_RoleId",
                table: "ElcRoleClaimsTest",
                newName: "IX_ElcRoleClaimsTest_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserTokensTest",
                table: "ElcUserTokensTest",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserRolesTest",
                table: "ElcUserRolesTest",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserLoginsTest",
                table: "ElcUserLoginsTest",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserClaimsTest",
                table: "ElcUserClaimsTest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcRolesTest",
                table: "ElcRolesTest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcRoleClaimsTest",
                table: "ElcRoleClaimsTest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ElcRoleClaimsTest_ElcRolesTest_RoleId",
                table: "ElcRoleClaimsTest",
                column: "RoleId",
                principalTable: "ElcRolesTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcRoleClaimsTest_ElcRolesTest_RoleId1",
                table: "ElcRoleClaimsTest",
                column: "RoleId1",
                principalTable: "ElcRolesTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_ElcUserRolesTest_ElcRolesTest_RoleId",
                table: "ElcUserRolesTest",
                column: "RoleId",
                principalTable: "ElcRolesTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
