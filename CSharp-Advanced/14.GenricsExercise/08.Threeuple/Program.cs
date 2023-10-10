namespace _08.Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAddressAndTown = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomThreeuple<string, string,string> nameAndAddressThreeuple = new CustomThreeuple<string, string,string>(nameAddressAndTown[0] + " " + nameAddressAndTown[1], nameAddressAndTown[2], string.Join(" ", nameAddressAndTown[3..]));
            Console.WriteLine(nameAndAddressThreeuple);


            string[] nameBeersAndIsDrunk = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool IsDrunk = false;
            if (nameBeersAndIsDrunk[2]=="drunk")
            {
                IsDrunk = true;
            }
            CustomThreeuple<string, int, bool> nameBeersAndIsDrunkThreeuple = new CustomThreeuple<string, int, bool>(nameBeersAndIsDrunk[0], int.Parse(nameBeersAndIsDrunk[1]), IsDrunk);
            Console.WriteLine(nameBeersAndIsDrunkThreeuple);


            string[] nameBalanceAndBank= Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomThreeuple<string, double, string> nameBalanceAndBankThreeuple = new CustomThreeuple<string, double, string>(nameBalanceAndBank[0], double.Parse(nameBalanceAndBank[1]), nameBalanceAndBank[2]);
            Console.WriteLine(nameBalanceAndBankThreeuple);

        }
    }
}