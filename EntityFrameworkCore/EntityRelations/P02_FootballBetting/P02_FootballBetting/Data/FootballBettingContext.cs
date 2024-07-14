using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using P02_FootballBetting.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data
{
	public class FootballBettingContext:DbContext
	{
        public FootballBettingContext()
        {
                
        }
        public FootballBettingContext(DbContextOptions<FootballBettingContext> options):base(options) 
        {
            
        }
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<Color> Colors { get; set; } = null!;
        public DbSet<Town> Towns { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
		public DbSet<PlayerStatistic> PlayersStatistics { get; set; } = null!;
		public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Bet> Bets { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("Server=KVALCHEV\\SQLEXPRESS;DataBase=FootballBetting;Integrated security=True;");
            }
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Team>().HasKey(t=>t.TeamId);
			//modelBuilder.Entity<Color>().HasKey(t => t.ColorId);
			//modelBuilder.Entity<Town>().HasKey(t => t.TownId);
			//modelBuilder.Entity<Country>().HasKey(t => t.CountryId);
			//modelBuilder.Entity<Player>().HasKey(t => t.PlayerId);
			//modelBuilder.Entity<Position>().HasKey(t => t.PositionId);
			modelBuilder.Entity<PlayerStatistic>(ps =>
            {
                ps.HasKey(ps => new {ps.PlayerId,ps.GameId});
            });
			//modelBuilder.Entity<Game>().HasKey(t => t.GameId);
			//modelBuilder.Entity<Bet>().HasKey(t => t.BetId);
			//modelBuilder.Entity<User>().HasKey(t => t.UserId);

		}
	}
}
