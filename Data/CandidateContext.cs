using Microsoft.EntityFrameworkCore;

namespace RazorCandidate.Models
{
  public class RazorCandidateContext : DbContext
  {
    public RazorCandidateContext(DbContextOptions<RazorCandidateContext> options)
        : base(options)
    {
    }

    public DbSet<RazorCandidate.Models.Candidate> Candidate { get; set; }
  }
}