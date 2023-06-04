namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeDefinition(double.Parse(Console.ReadLine()));  
        }
        static void GradeDefinition(double grade)
        {
            if(grade>=2&&grade<3) Console.WriteLine("Fail");
           else if(grade>=3&&grade<3.50) Console.WriteLine("Poor");
           else if(grade>=3.5&&grade<4.50) Console.WriteLine("Good");
           else if(grade>=4.5&&grade<5.50) Console.WriteLine("Very good");
           else Console.WriteLine("Excellent");
        }
    }
}