namespace ScratchCards.Data
{
    using Microsoft.EntityFrameworkCore;
    public class ScratchCardsDbContext : DbContext
    {
        public ScratchCardsDbContext(DbContextOptions<ScratchCardsDbContext> options) : base(options)
        {
        }
    }
}
