using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualWarehouse.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentAssetId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedByUserId = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_Assets_ParentAssetId",
                        column: x => x.ParentAssetId,
                        principalTable: "Assets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SavedImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginalFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SafeFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Folder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedByUserId = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoryAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedByUserId = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryAttributes_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ImageAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedByUserId = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageAttributes_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TextAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedByUserId = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextAttributes_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HistoryAttributeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoryAttributeId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<double>(type: "float", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedByUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryAttributeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryAttributeItems_HistoryAttributes_HistoryAttributeId",
                        column: x => x.HistoryAttributeId,
                        principalTable: "HistoryAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ParentAssetId",
                table: "Assets",
                column: "ParentAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryAttributeItems_HistoryAttributeId",
                table: "HistoryAttributeItems",
                column: "HistoryAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryAttributes_AssetId",
                table: "HistoryAttributes",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageAttributes_AssetId",
                table: "ImageAttributes",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_TextAttributes_AssetId",
                table: "TextAttributes",
                column: "AssetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryAttributeItems");

            migrationBuilder.DropTable(
                name: "ImageAttributes");

            migrationBuilder.DropTable(
                name: "SavedImages");

            migrationBuilder.DropTable(
                name: "TextAttributes");

            migrationBuilder.DropTable(
                name: "HistoryAttributes");

            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
