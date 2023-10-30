using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eol.Models
{
  public class EolContext : IdentityDbContext<ApplicationUser>
  { 
    public DbSet<Message> Messages { get; set; }
    
    public EolContext(DbContextOptions options) : base(options) { }
  }


//  protected override void OnModelCreating(ModelBuilder builder)
//     {
//       //the line below is needed to seed user data
//       base.OnModelCreating(builder);
      
//       builder.Entity<ApplicationUser>()
//         .HasData(
//           new ApplicationUser {UserName = "ScarySpice", }
//         );
//     }
}