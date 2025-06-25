using System.Globalization;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" what is your favorite subject at school?");
            string favSubject= Console.ReadLine();

            switch (favSubject)
            {
                case "math":
                    Console.WriteLine($"i love {favSubject} too");
                    break;
                case "geography":
                    Console.WriteLine($"{favSubject} rocks");
                    break; 
                case "history":
                    Console.WriteLine("did you know that Ethiopia was never colonized?");
                    break;
                case "sports":
                    Console.WriteLine("my 12 years old daughter is a good basketball player!");
                    break;
                case "english":
                    Console.WriteLine("English is not my first language. In fact, it is not my second language either!");
                    break;
                default:
                    Console.WriteLine($"{favSubject}, good choice");
                    break;
            }
        }
    }
}