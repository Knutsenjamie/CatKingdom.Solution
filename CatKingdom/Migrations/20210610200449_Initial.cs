using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatKingdom.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Breed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 7, "Tuxedo/American Shorthair", "The most chill cat you will ever meet. Peppermint loves snuggles, catnip, and his favorite mouse toy that has a bell inside of it.", "Male", "Peppermint" },
                    { 2, 3, "Calico/American Shorthair", "A little fiesty at times, Mocha loves to love on HER terms- but when she does, she can be a real sweetheart. Her favorite things include wet food, and her ball toy that makes crinkle sounds.", "Female", "Mocha" },
                    { 3, 5, "Bombay", "Talkative af. Will always want to loudly chat it up with you and make her presence known. Lola loves to rub against your legs, say hi, and play with crinkled up pieces of paper.", "Female", "Lola" },
                    { 4, 16, "Tabby/American Shorthair", "A sweet, patient old gentleman, Charles loves to nap and sit on your lap. He will play a little from time to time with his bird toy.", "Male", "Charles" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");
        }
    }
}
