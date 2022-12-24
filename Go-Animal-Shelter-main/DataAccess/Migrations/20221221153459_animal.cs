using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class animal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwner_PetOwnerId",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veterersians",
                table: "Veterersians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetOwner",
                table: "PetOwner");

            migrationBuilder.RenameTable(
                name: "Veterersians",
                newName: "Veterinerians");

            migrationBuilder.RenameTable(
                name: "PetOwner",
                newName: "PetsOwners");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterinerians",
                table: "Veterinerians",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetsOwners",
                table: "PetsOwners",
                column: "PetOwnerId");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetsOwners_PetOwnerId",
                table: "Pets",
                column: "PetOwnerId",
                principalTable: "PetsOwners",
                principalColumn: "PetOwnerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetsOwners_PetOwnerId",
                table: "Pets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veterinerians",
                table: "Veterinerians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetsOwners",
                table: "PetsOwners");

            migrationBuilder.RenameTable(
                name: "Veterinerians",
                newName: "Veterersians");

            migrationBuilder.RenameTable(
                name: "PetsOwners",
                newName: "PetOwner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterersians",
                table: "Veterersians",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetOwner",
                table: "PetOwner",
                column: "PetOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwner_PetOwnerId",
                table: "Pets",
                column: "PetOwnerId",
                principalTable: "PetOwner",
                principalColumn: "PetOwnerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
