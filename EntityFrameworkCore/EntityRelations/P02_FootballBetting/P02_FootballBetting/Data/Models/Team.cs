using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
	public class Team
	{
        public Team()
        {
			HomeGames=new HashSet<Game>();
			AwayGames = new HashSet<Game>();
			Players=new HashSet<Player>();
		}

		[Key]
		public int TeamId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }= null!;
		[Required]
		[MaxLength(200)]
		public string LogoUrl { get; set; } = null!;
		[Required]
		[MaxLength(10)]
		public string Initials { get; set; } = null!;

		[Required]
		public decimal Budget { get; set; }

	
		public int PrimaryKitColorId { get; set; }

		[ForeignKey(nameof(PrimaryKitColorId))]
		public Color PrimaryKitColor { get; set; }

	
		public int SecondaryKitColorId { get; set; }

		[ForeignKey(nameof(SecondaryKitColorId))]
		public Color SecondaryKitColor { get; set; }

		[Required]
		public int TownId { get; set; }

		[ForeignKey(nameof(TownId))]
		public Town Town { get; set; }
		[InverseProperty(nameof(Game.HomeTeam))]
		public virtual ICollection<Game> HomeGames { get; set; }
		[InverseProperty(nameof(Game.AwayTeam))]
		public virtual ICollection<Game> AwayGames { get; set; }
		public virtual ICollection<Player> Players { get; set; }
	}
}
