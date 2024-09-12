using ElonMusk_portfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace ElonMusk_portfolio.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
              
        }

    }
}
