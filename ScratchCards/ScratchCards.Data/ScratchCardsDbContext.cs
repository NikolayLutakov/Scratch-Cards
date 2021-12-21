namespace ScratchCards.Data
{
    using Microsoft.EntityFrameworkCore;
    using ScratchCards.Entities;

    public class ScratchCardsDbContext : DbContext
    {
        public ScratchCardsDbContext(DbContextOptions<ScratchCardsDbContext> options) : base(options)
        {
        }

        public DbSet<AutoplayButton> AutoplayButtons { get; set; }
        public DbSet<BalanceContainer> BalanceContainers { get; set; }
        public DbSet<BetContainer> BetContainers { get; set; }
        public DbSet<BonusGameContainer> BonusGameContainers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GameTypes { get; set; }
        public DbSet<InfoButton> InfoButtons { get; set; }
        public DbSet<JackpotContainer> JackpotContainers { get; set; }
        public DbSet<PlayButton> PlayButtons { get; set; }
        public DbSet<SoundButton> SoundButtons { get; set; }
        public DbSet<SuperBonusGameContainer> SuperBonusGameContainers { get; set; }
        public DbSet<Symbol> Symbols { get; set; }
        public DbSet<WinSymbolsContainer> WinSymbolsContainers { get; set; }
        public DbSet<YourSymbolsContainer> YourSymbolsContainers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BalanceContainer>()
                .Property(a => a.Amount)
                .HasPrecision(14,2);

            modelBuilder.Entity<JackpotContainer>()
               .Property(a => a.Amount)
               .HasPrecision(14, 2);
        }
    }
}
