using Microsoft.EntityFrameworkCore;

namespace Adsmini.Models
{
    /// <summary>
    /// Контекст подключения к базе данных.
    /// </summary>
    public class AdsminiContext : DbContext
    {
        /// <summary>
        /// Создать новый экземпляр контекста данных.
        /// </summary>
        public AdsminiContext()
        {
            // Гарантируем, что база данных существует.
            Database.EnsureCreated();
        }

        /// <summary>
        /// Конфигуратор подключения. 
        /// </summary>
        /// <param name="optionsBuilder"> Свойства конфигуратора. </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Указываем строку подключения к базе данных.
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=adsmini;Trusted_Connection=True;");
        }

        /// <summary>
        /// Объявления. 
        /// </summary>
        public DbSet<Card> Cards { get; set; }

        /// <summary>
        /// Категории. 
        /// </summary>
        public DbSet<Type> Types { get; set; }

        /// <summary>
        /// Города.
        /// </summary>
        public DbSet<City> Cities { get; set; }
    }
}
