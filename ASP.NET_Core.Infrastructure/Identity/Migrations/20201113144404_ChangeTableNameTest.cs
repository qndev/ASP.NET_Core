using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core.Infrastructure.Identity.Migrations
{
    public partial class ChangeTableNameTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserRoles_ElcRoles_RoleId",
                table: "ElcUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserRoles_ElcUsers_UserId",
                table: "ElcUserRoles");

            migrationBuilder.DropTable(
                name: "ElcRoleClaims");

            migrationBuilder.DropTable(
                name: "ElcUserClaims");

            migrationBuilder.DropTable(
                name: "ElcUserLogins");

            migrationBuilder.DropTable(
                name: "ElcUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUsers",
                table: "ElcUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUserRoles",
                table: "ElcUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcRoles",
                table: "ElcRoles");

            migrationBuilder.RenameTable(
                name: "ElcUsers",
                newName: "ElcUsersTest");

            migrationBuilder.RenameTable(
                name: "ElcUserRoles",
                newName: "ElcUserRolesTest");

            migrationBuilder.RenameTable(
                name: "ElcRoles",
                newName: "ElcRolesTest");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserRoles_RoleId",
                table: "ElcUserRolesTest",
                newName: "IX_ElcUserRolesTest_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUsersTest",
                table: "ElcUsersTest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserRolesTest",
                table: "ElcUserRolesTest",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcRolesTest",
                table: "ElcRolesTest",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ElcRoleClaimsTest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElcRoleClaimsTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElcRoleClaimsTest_ElcRolesTest_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ElcRolesTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElcRoleClaimsTest_ElcRolesTest_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "ElcRolesTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElcUserClaimsTest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElcUserClaimsTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElcUserClaimsTest_ElcUsersTest_UserId",
                        column: x => x.UserId,
                        principalTable: "ElcUsersTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElcUserClaimsTest_ElcUsersTest_UserId1",
                        column: x => x.UserId1,
                        principalTable: "ElcUsersTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElcUserLoginsTest",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElcUserLoginsTest", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_ElcUserLoginsTest_ElcUsersTest_UserId",
                        column: x => x.UserId,
                        principalTable: "ElcUsersTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElcUserLoginsTest_ElcUsersTest_UserId1",
                        column: x => x.UserId1,
                        principalTable: "ElcUsersTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElcUserTokensTest",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElcUserTokensTest", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_ElcUserTokensTest_ElcUsersTest_UserId",
                        column: x => x.UserId,
                        principalTable: "ElcUsersTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElcUserTokensTest_ElcUsersTest_UserId1",
                        column: x => x.UserId1,
                        principalTable: "ElcUsersTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElcRoleClaimsTest_RoleId",
                table: "ElcRoleClaimsTest",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ElcRoleClaimsTest_RoleId1",
                table: "ElcRoleClaimsTest",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_ElcUserClaimsTest_UserId",
                table: "ElcUserClaimsTest",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ElcUserClaimsTest_UserId1",
                table: "ElcUserClaimsTest",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ElcUserLoginsTest_UserId",
                table: "ElcUserLoginsTest",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ElcUserLoginsTest_UserId1",
                table: "ElcUserLoginsTest",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ElcUserTokensTest_UserId1",
                table: "ElcUserTokensTest",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserRolesTest_ElcRolesTest_RoleId",
                table: "ElcUserRolesTest",
                column: "RoleId",
                principalTable: "ElcRolesTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElcUserRolesTest_ElcUsersTest_UserId",
                table: "ElcUserRolesTest",
                column: "UserId",
                principalTable: "ElcUsersTest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserRolesTest_ElcRolesTest_RoleId",
                table: "ElcUserRolesTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ElcUserRolesTest_ElcUsersTest_UserId",
                table: "ElcUserRolesTest");

            migrationBuilder.DropTable(
                name: "ElcRoleClaimsTest");

            migrationBuilder.DropTable(
                name: "ElcUserClaimsTest");

            migrationBuilder.DropTable(
                name: "ElcUserLoginsTest");

            migrationBuilder.DropTable(
                name: "ElcUserTokensTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUsersTest",
                table: "ElcUsersTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcUserRolesTest",
                table: "ElcUserRolesTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElcRolesTest",
                table: "ElcRolesTest");

            migrationBuilder.RenameTable(
                name: "ElcUsersTest",
                newName: "ElcUsers");

            migrationBuilder.RenameTable(
                name: "ElcUserRolesTest",
                newName: "ElcUserRoles");

            migrationBuilder.RenameTable(
                name: "ElcRolesTest",
                newName: "ElcRoles");

            migrationBuilder.RenameIndex(
                name: "IX_ElcUserRolesTest_RoleId",
                table: "ElcUserRoles",
                newName: "IX_ElcUserRoles_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUsers",
                table: "ElcUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcUserRoles",
                table: "ElcUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElcRoles",
                table: "ElcRoles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ElcRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElcRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElcRoleClaims_ElcRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ElcRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElcUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElcUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElcUserClaims_ElcUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ElcUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElcUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElcUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_ElcUserLogins_ElcUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ElcUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElcUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Name = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Value = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElcUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_ElcUserTokens_ElcUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ElcUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElcRoleClaims_RoleId",
                table: "ElcRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ElcUserClaims_UserId",
                table: "ElcUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ElcUserLogins_UserId",
                table: "ElcUserLogins",
                column: "UserId");

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
        }
    }
}
