namespace _06.MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",");
            Dictionary<string,double> accounts=new Dictionary<string,double>();
            for (int i = 0; i < input.Length; i++)
            {
                accounts.Add(input[i].Split("-")[0], double.Parse(input[i].Split("-")[1]));
            }
            string command;
            while ((command=Console.ReadLine())!="End")
            {
                try
                {
                    string[] tokens = command.Split();
                    if (tokens[0] == "Deposit")
                    {
                        if (accounts.ContainsKey(tokens[1]))
                        {
                            accounts[tokens[1]] += double.Parse(tokens[2]);
                        }
                        else
                        {

                            throw new InvalidAccount("Invalid account!");
                        }
                    }
                    else if (tokens[0] == "Withdraw")
                    {
                        if (accounts.ContainsKey(tokens[1]))
                        {
                            if(double.Parse(tokens[2])> accounts[tokens[1]])
                            {
                                throw new InsufficientBalance("Insufficient balance!");
                            }
                            accounts[tokens[1]] -= double.Parse(tokens[2]);
                        }
                        else
                        {

                            throw new InvalidAccount("Invalid Account!");
                        }
                    }
                    else
                    {
                        throw new InvalidCommand("Invalid command!");
                    }
                    Console.WriteLine($"Account {tokens[1]} has new balance: {accounts[tokens[1]]:f2}");
                }
                catch(Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }

    }
    public class InvalidCommand : Exception
    {
        public InvalidCommand(string message):base(message) 
        {
        }
    }
    public class InvalidAccount : Exception
    {
        public InvalidAccount(string message) : base(message)
        {
        }
    }
    public class InsufficientBalance : Exception
    {
        public InsufficientBalance(string message) : base(message)
        {
        }
    }
}