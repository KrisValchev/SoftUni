using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
	public class Game
	{
        public Game()
        {
			PlayersStatistics = new HashSet<PlayerStatistic>();
			Bets = new HashSet<Bet>();
		}
		[Key]
		public int GameId { get; set; }
		[Required]
		public int HomeTeamId { get; set; }
		[ForeignKey(nameof(HomeTeamId))]
		public Team HomeTeam { get; set; }
		[Required]
		public int AwayTeamId { get; set; }
		[ForeignKey(nameof(AwayTeamId))]
		public Team AwayTeam { get; set; }

		[Required]
		public int HomeTeamGoals {  get; set; }
		[Required]
		public int AwayTeamGoals { get; set; }
		[Required]
		public double HomeTeamBetRate { get; set; }
		[Required]
		public double AwayTeamBetRate { get; set; }
		[Required]
		public double DrawBetRate { get; set; }

		[Required]
		public DateTime DateTime { get; set; }
		[Required]
		public string Result { get; set; } = null!;
		public virtual ICollection<PlayerStatistic> PlayersStatistics { get; set; }
		public virtual ICollection<Bet> Bets { get; set; }
	}
}
