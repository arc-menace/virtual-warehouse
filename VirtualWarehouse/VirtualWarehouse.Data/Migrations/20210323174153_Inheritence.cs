using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualWarehouse.Data.Migrations
{
    public partial class Inheritence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Things",
                columns: table => new
                {
                    ThingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Things", x => x.ThingId);
                    table.ForeignKey(
                        name: "FK_Things_Things_ThingId1",
                        column: x => x.ThingId1,
                        principalTable: "Things",
                        principalColumn: "ThingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThingAttributes",
                columns: table => new
                {
                    ThingAttributeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThingAttributes", x => x.ThingAttributeId);
                    table.ForeignKey(
                        name: "FK_ThingAttributes_Things_ThingId",
                        column: x => x.ThingId,
                        principalTable: "Things",
                        principalColumn: "ThingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThingAttributes_ThingId",
                table: "ThingAttributes",
                column: "ThingId");

            migrationBuilder.CreateIndex(
                name: "IX_Things_ThingId1",
                table: "Things",
                column: "ThingId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThingAttributes");

            migrationBuilder.DropTable(
                name: "Things");
        }
    }
}
