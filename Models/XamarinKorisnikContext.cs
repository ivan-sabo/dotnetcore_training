using Microsoft.EntityFrameworkCore;

namespace cSharpApi.Models
{
    public class XamarinKorisnikContext : DbContext
    {
        public XamarinKorisnikContext(DbContextOptions<XamarinKorisnikContext> options)
            : base(options)
        {
        }

        public DbSet<XamarinKorisnik> XamarinKorisnik { get; set; }
    }
}