using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class userrelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationClaimUser",
                columns: table => new
                {
                    OperationClaimsId = table.Column<int>(type: "integer", nullable: false),
                    usersUserID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaimUser", x => new { x.OperationClaimsId, x.usersUserID });
                    table.ForeignKey(
                        name: "FK_OperationClaimUser_OperationClaims_OperationClaimsId",
                        column: x => x.OperationClaimsId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationClaimUser_Users_usersUserID",
                        column: x => x.usersUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OperationClaimUser_usersUserID",
                table: "OperationClaimUser",
                column: "usersUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationClaimUser");
        }
    }
}
