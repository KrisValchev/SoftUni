namespace Stealer
{
    public class StartUo
    {
        static void Main(string[] args)
        {
            Spy spy=new Spy();
            string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");
            Console.WriteLine(result);
        }
    }
}