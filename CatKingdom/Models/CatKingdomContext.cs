using Microsoft.EntityFrameworkCore;

namespace CatKingdom.Models
{
    public class CatKingdomContext : DbContext
    {
        public CatKingdomContext(DbContextOptions<CatKingdomContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Cat>()
              .HasData(
                new Cat { CatId = 1, Name = "Peppermint", Breed = "Tuxedo/American Shorthair", Description = "The most chill cat you will ever meet. Peppermint loves snuggles, catnip, and his favorite mouse toy that has a bell inside of it.", Age = 7, Gender = "Male"},
                new Cat { CatId = 2, Name = "Mocha", Breed = "Calico/American Shorthair", Description = "A little fiesty at times, Mocha loves to love on HER terms- but when she does, she can be a real sweetheart. Her favorite things include wet food, and her ball toy that makes crinkle sounds.", Age = 3, Gender = "Female"},
                new Cat { CatId = 3, Name = "Lola", Breed = "Bombay", Description = "Talkative af. Will always want to loudly chat it up with you and make her presence known. Lola loves to rub against your legs, say hi, and play with crinkled up pieces of paper.", Age = 5, Gender = "Female"},
                new Cat { CatId = 4, Name = "Charles", Breed = "Tabby/American Shorthair", Description = "A sweet, patient old gentleman, Charles loves to nap and sit on your lap. He will play a little from time to time with his bird toy.", Age = 16, Gender = "Male"}
              );
        }

        public DbSet<Cat> Cats { get; set; }
    }
}