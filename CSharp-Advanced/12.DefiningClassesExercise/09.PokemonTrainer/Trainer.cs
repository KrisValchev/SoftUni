using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
		private string name;
		private int badges;
		private List<Pokemon> pokemons=new List<Pokemon>();

		public List<Pokemon> Pokemons

		{
			get { return pokemons; }
			set { pokemons = value; }
		}

		public int Badges
		{
			get { return badges; }
			set { badges = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
        public Trainer()
        {
			this.Badges = 0;
        }
		public Trainer(string name,Pokemon pokemon):this()
		{
			this.Name = name;
			this.Pokemons.Add(pokemon);
			
		}
        public void CheckElement(string element)
        {
            if (Pokemons.Any(x => x.Element == element))
            {
                this.Badges++;
            }
            else
            {
				for (int i = 0; i < Pokemons.Count; i++)
				{
                    Pokemon currentPokemon = Pokemons[i];

                    currentPokemon.Health -= 10;

                    if (currentPokemon.Health <= 0)
                    {
                        Pokemons.Remove(currentPokemon);
                    }
                }

            }
           
        }
    }
}
