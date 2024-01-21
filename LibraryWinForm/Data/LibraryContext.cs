using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using LibraryWinForm.Data.Entities;

namespace LibraryWinForm.Data;

public class LibraryContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<BookEntity> Books { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration configuration = builder.Build();

        string? conStr = configuration.GetConnectionString("MSSQLServerConnection");
        
        optionsBuilder.UseSqlServer(conStr);
    }
}