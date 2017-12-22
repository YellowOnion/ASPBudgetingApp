using Microsoft.EntityFrameworkCore;

namespace ASPBudgetingApp.Models
{
    public class BudgetContext : DbContext
    {
        public BudgetContext (DbContextOptions<BudgetContext> options) : base(options)
        {
        }
        public DbSet<Budget> BudgetSet { get; set; }
    }
}