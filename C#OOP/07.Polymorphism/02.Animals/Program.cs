using System.Text;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("George", "Meat");
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

        }
    }
    public class Animal
    {
        protected string name;
        protected string favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }
        public virtual string ExplainSelf()
        {
            return " ";
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, string favouiteFood) : base(name, favouiteFood) {
        }
        public override string ExplainSelf()
        {
            StringBuilder stringBuilder = new StringBuilder();  stringBuilder.AppendLine($"I am {base.name} and my favourite food is {base.favouriteFood}");
         stringBuilder.AppendLine($"MEEOW");
            return stringBuilder.ToString().Trim();
        }
    }
    public class Dog : Animal
    {
        public Dog(string name, string favouiteFood) : base(name, favouiteFood)
        {
        }
        public override string ExplainSelf()
        {
            StringBuilder stringBuilder = new StringBuilder(); stringBuilder.AppendLine($"I am {base.name} and my favourite food is {base.favouriteFood}");
            stringBuilder.AppendLine($"DJAAF");
            return stringBuilder.ToString().Trim();
        }
    }
}