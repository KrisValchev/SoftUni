namespace _03.Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = new List<string>(Console.ReadLine().Split(", "));
            Dictionary<string, string> suitAndLiteral = new Dictionary<string, string>()
            {
                {"S", "\u2660"},
                {"H", "\u2665"},
                {"D", "\u2666"},
                {"C", "\u2663"}
            };
            List<string> validCards = new List<string>();
            for (int i = 0; i < cards.Count; i++)
            {
                try
                {
                    string face = cards[i].Split()[0];
                    string suit = cards[i].Split()[1];
                    Card card = new Card(face, suit);
                   validCards.Add($"[{face}{suitAndLiteral[suit]}]");
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(string.Join(" ",validCards));

        }

    }
    class Card
    {
        private string face;
        private string suit;
        private List<string> faces = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private List<string> suits = new List<string> { "S", "H", "D", "C" };

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public string Suit
        {
            get { return suit; }
            private set
            {
                if (!suits.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                suit = value;
            }
        }

        public string Face
        {
            get { return face; }
            private set
            {
                if (!faces.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                face = value;
            }
        }

    }
}