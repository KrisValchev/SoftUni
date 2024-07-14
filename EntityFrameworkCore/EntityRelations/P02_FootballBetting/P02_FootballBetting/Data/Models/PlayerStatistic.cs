using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
	public class PlayerStatistic
	{
		[Required]
		public int GameId { get; set; }
		[ForeignKey(nameof(GameId))]
		public Game Game { get; set; }
		[Required]
		public int PlayerId { get; set; }
		[ForeignKey(nameof(PlayerId))]
		public Player Player { get; set; }

		[Required]
		public int ScoredGoals { get; set; }
		[Required]
		public int Assists { get; set; }
		[Required]
		public int MinutesPlayed { get; set; }
	}
}
