namespace _09.PokemonTrainer
{
    public class StartUp
    {
        static void Main()
        {
            string command;
            List<Trainer> trainers = new List<Trainer>();
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string trainerName = command.Split()[0];
                string pokemonName = command.Split()[1];
                string pokemonElement = command.Split()[2];
                int pokemonHealth = int.Parse(command.Split()[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName, pokemon);
                if (trainers.Any(x => x.Name == trainerName))
                {
                    trainers.Find(x => x.Name == trainerName).Pokemons.Add(pokemon);
                }
                else
                {
                    trainers.Add(trainer);
                }
            }
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.CheckElement(command);
                }
            }
            foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}