namespace unitTesting_uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = UserNumber(number);
            Console.WriteLine(result);

            Console.WriteLine("Iveskit slaptazodi: ");
            string userInput = Console.ReadLine();
            string result2 = CheckPassword(userInput);
            Console.WriteLine(result2);
        }

        public static string UserNumber(int number)
        {
            if (number > 100)
            {
                return "Skaicius yra didesnis uz 100";
            }
            else if (number == 100)
            {
                return "Skaicius yra lygus 100";
            }
            else
            {
                return "Skaicius yra mazesnis uz 100";
            }
        }
        public static string CheckPassword(string userInput)
        {
            if (userInput == "Robertas" || userInput == "Mellon")
            {
                return "Sekmingai prisijungete";
            }
            else if (userInput == "01101001 01101110")
            {
                return "Nulauzta";
            }
            else
            {
                return "Slaptazodis neteisingas, prasome bandyti dar karta..";
            }
        }
    }
}