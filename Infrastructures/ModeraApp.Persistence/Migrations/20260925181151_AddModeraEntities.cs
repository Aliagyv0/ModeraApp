using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeraApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddModeraEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClothingItem_AspNetUsers_UserId",
                table: "ClothingItem");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneratedImage_Outfit_OutfitId",
                table: "GeneratedImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Outfit_AspNetUsers_UserId",
                table: "Outfit");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitItem_ClothingItem_ClothingItemId",
                table: "OutfitItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitItem_Outfit_OutfitId",
                table: "OutfitItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitItem",
                table: "OutfitItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Outfit",
                table: "Outfit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneratedImage",
                table: "GeneratedImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClothingItem",
                table: "ClothingItem");

            migrationBuilder.RenameTable(
                name: "OutfitItem",
                newName: "OutfitItems");

            migrationBuilder.RenameTable(
                name: "Outfit",
                newName: "Outfits");

            migrationBuilder.RenameTable(
                name: "GeneratedImage",
                newName: "GeneratedImages");

            migrationBuilder.RenameTable(
                name: "ClothingItem",
                newName: "ClothingItems");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitItem_OutfitId",
                table: "OutfitItems",
                newName: "IX_OutfitItems_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitItem_ClothingItemId",
                table: "OutfitItems",
                newName: "IX_OutfitItems_ClothingItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Outfit_UserId",
                table: "Outfits",
                newName: "IX_Outfits_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GeneratedImage_OutfitId",
                table: "GeneratedImages",
                newName: "IX_GeneratedImages_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_ClothingItem_UserId",
                table: "ClothingItems",
                newName: "IX_ClothingItems_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitItems",
                table: "OutfitItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Outfits",
                table: "Outfits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneratedImages",
                table: "GeneratedImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClothingItems",
                table: "ClothingItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClothingItems_AspNetUsers_UserId",
                table: "ClothingItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneratedImages_Outfits_OutfitId",
                table: "GeneratedImages",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitItems_ClothingItems_ClothingItemId",
                table: "OutfitItems",
                column: "ClothingItemId",
                principalTable: "ClothingItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitItems_Outfits_OutfitId",
                table: "OutfitItems",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Outfits_AspNetUsers_UserId",
                table: "Outfits",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClothingItems_AspNetUsers_UserId",
                table: "ClothingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneratedImages_Outfits_OutfitId",
                table: "GeneratedImages");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitItems_ClothingItems_ClothingItemId",
                table: "OutfitItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitItems_Outfits_OutfitId",
                table: "OutfitItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Outfits_AspNetUsers_UserId",
                table: "Outfits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Outfits",
                table: "Outfits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitItems",
                table: "OutfitItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneratedImages",
                table: "GeneratedImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClothingItems",
                table: "ClothingItems");

            migrationBuilder.RenameTable(
                name: "Outfits",
                newName: "Outfit");

            migrationBuilder.RenameTable(
                name: "OutfitItems",
                newName: "OutfitItem");

            migrationBuilder.RenameTable(
                name: "GeneratedImages",
                newName: "GeneratedImage");

            migrationBuilder.RenameTable(
                name: "ClothingItems",
                newName: "ClothingItem");

            migrationBuilder.RenameIndex(
                name: "IX_Outfits_UserId",
                table: "Outfit",
                newName: "IX_Outfit_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitItems_OutfitId",
                table: "OutfitItem",
                newName: "IX_OutfitItem_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitItems_ClothingItemId",
                table: "OutfitItem",
                newName: "IX_OutfitItem_ClothingItemId");

            migrationBuilder.RenameIndex(
                name: "IX_GeneratedImages_OutfitId",
                table: "GeneratedImage",
                newName: "IX_GeneratedImage_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_ClothingItems_UserId",
                table: "ClothingItem",
                newName: "IX_ClothingItem_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Outfit",
                table: "Outfit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitItem",
                table: "OutfitItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneratedImage",
                table: "GeneratedImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClothingItem",
                table: "ClothingItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClothingItem_AspNetUsers_UserId",
                table: "ClothingItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneratedImage_Outfit_OutfitId",
                table: "GeneratedImage",
                column: "OutfitId",
                principalTable: "Outfit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Outfit_AspNetUsers_UserId",
                table: "Outfit",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitItem_ClothingItem_ClothingItemId",
                table: "OutfitItem",
                column: "ClothingItemId",
                principalTable: "ClothingItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitItem_Outfit_OutfitId",
                table: "OutfitItem",
                column: "OutfitId",
                principalTable: "Outfit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
