﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
	public class User
	{
        public User()
        {
            Bets=new HashSet<Bet>();
        }
        [Key]
		public int UserId { get; set; }
		[Required]
		[MaxLength(50)]
		public string Username { get; set; } = null!;
		[Required]
		[MaxLength(50)]
		public string Name { get; set; } = null!;
		[Required]
		[MaxLength(50)]
		public string Password { get; set; } = null!;
		[Required]
		[MaxLength(100)]
		public string Email { get; set; } = null!;
		[Required]
		public decimal Balance { get; set; }

		public virtual ICollection<Bet> Bets { get; set;}
	}
}
