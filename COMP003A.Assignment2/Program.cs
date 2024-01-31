namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string firstname = Console.ReadLine();
            string middlename = Console.ReadLine();
            string lastname = Console.ReadLine();
            string inputAge = Console.ReadLine();
            int yearborn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstname} {middlename} {lastname} You were born in {yearborn}");

            // Get string input from the user
            Console.WriteLine("Enter an integer ");
            string inputString = Console.ReadLine();
            { 
                int integer1 = int.Parse(inputString);
                Console.WriteLine($"You enetered: (integer1)");
                }
            {
                int integer2 = int.Parse(inputString);
                Console.WriteLine($"You enetered: (integer2)");
            }

            Console.WriteLine($"{integer1}+{integer2} = {integer1 + integer2}");

            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI + Math.Pow(radius, 2);
            double circumfrence = 2 + Math.PI + radius;
        }
    }
}
