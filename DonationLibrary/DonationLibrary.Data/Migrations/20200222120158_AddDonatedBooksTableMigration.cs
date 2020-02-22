using Microsoft.EntityFrameworkCore.Migrations;

namespace DonationLibrary.Data.Migrations
{
    public partial class AddDonatedBooksTableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookRecipient_Books_BookId",
                table: "BookRecipient");

            migrationBuilder.DropForeignKey(
                name: "FK_BookRecipient_Recipients_RecipientId",
                table: "BookRecipient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookRecipient",
                table: "BookRecipient");

            migrationBuilder.RenameTable(
                name: "BookRecipient",
                newName: "DonatedBooks");

            migrationBuilder.RenameIndex(
                name: "IX_BookRecipient_RecipientId",
                table: "DonatedBooks",
                newName: "IX_DonatedBooks_RecipientId");

            migrationBuilder.RenameIndex(
                name: "IX_BookRecipient_BookId",
                table: "DonatedBooks",
                newName: "IX_DonatedBooks_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonatedBooks",
                table: "DonatedBooks",
                columns: new[] { "BookId", "RecipientId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DonatedBooks_Books_BookId",
                table: "DonatedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonatedBooks_Recipients_RecipientId",
                table: "DonatedBooks",
                column: "RecipientId",
                principalTable: "Recipients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonatedBooks_Books_BookId",
                table: "DonatedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_DonatedBooks_Recipients_RecipientId",
                table: "DonatedBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonatedBooks",
                table: "DonatedBooks");

            migrationBuilder.RenameTable(
                name: "DonatedBooks",
                newName: "BookRecipient");

            migrationBuilder.RenameIndex(
                name: "IX_DonatedBooks_RecipientId",
                table: "BookRecipient",
                newName: "IX_BookRecipient_RecipientId");

            migrationBuilder.RenameIndex(
                name: "IX_DonatedBooks_BookId",
                table: "BookRecipient",
                newName: "IX_BookRecipient_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookRecipient",
                table: "BookRecipient",
                columns: new[] { "BookId", "RecipientId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookRecipient_Books_BookId",
                table: "BookRecipient",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookRecipient_Recipients_RecipientId",
                table: "BookRecipient",
                column: "RecipientId",
                principalTable: "Recipients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
