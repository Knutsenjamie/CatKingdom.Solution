// <auto-generated />
using CatKingdom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatKingdom.Migrations
{
    [DbContext(typeof(CatKingdomContext))]
    partial class CatKingdomContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CatKingdom.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Age = 7,
                            Breed = "Tuxedo/American Shorthair",
                            Description = "The most chill cat you will ever meet. Peppermint loves snuggles, catnip, and his favorite mouse toy that has a bell inside of it.",
                            Gender = "Male",
                            Name = "Peppermint"
                        },
                        new
                        {
                            CatId = 2,
                            Age = 3,
                            Breed = "Calico/American Shorthair",
                            Description = "A little fiesty at times, Mocha loves to love on HER terms- but when she does, she can be a real sweetheart. Her favorite things include wet food, and her ball toy that makes crinkle sounds.",
                            Gender = "Female",
                            Name = "Mocha"
                        },
                        new
                        {
                            CatId = 3,
                            Age = 5,
                            Breed = "Bombay",
                            Description = "Talkative af. Will always want to loudly chat it up with you and make her presence known. Lola loves to rub against your legs, say hi, and play with crinkled up pieces of paper.",
                            Gender = "Female",
                            Name = "Lola"
                        },
                        new
                        {
                            CatId = 4,
                            Age = 16,
                            Breed = "Tabby/American Shorthair",
                            Description = "A sweet, patient old gentleman, Charles loves to nap and sit on your lap. He will play a little from time to time with his bird toy.",
                            Gender = "Male",
                            Name = "Charles"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
