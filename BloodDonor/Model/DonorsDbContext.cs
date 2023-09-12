using Microsoft.EntityFrameworkCore;

namespace BloodDonor.Model
{
    public class DonorsDbContext : DbContext
    {
        public DonorsDbContext(DbContextOptions<DonorsDbContext> options) : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
    }
}
