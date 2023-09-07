using System.Net.NetworkInformation;

namespace UnitTestingExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Skaiciuotuvas =====");
            Console.WriteLine("1. sudetis");
            Console.WriteLine("2. atimtis");
            Console.WriteLine("3. daugyba");
            Console.WriteLine("4. dalyba");
            Console.WriteLine("5. kelimas laipsniu");
            Console.WriteLine("6. saknis");
            Console.WriteLine("7. q - baigti programa");
            Console.WriteLine(" ");
                        
            double result = 0.0;

            while (true)
            {
                Console.WriteLine("Iveskit veiksma kuri norite atlikti: ");
                string veiksmas = Console.ReadLine();

                if (veiksmas == "q")
                {
                    break;
                }
                
                Console.WriteLine("Iveskit pirmaji skaiciu: ");
                string inputNumber = Console.ReadLine();

                if (inputNumber == "q")
                {
                    break;
                }               
                double number = Convert.ToDouble(inputNumber);

                double number2 = 0.0;

                if (veiksmas != "saknis")
                {
                    Console.WriteLine("Iveskit antra skaiciu: ");
                    string inputNumber2 = Console.ReadLine();

                    if (inputNumber2 == "q")
                    {
                        break;
                    }

                    number2 = Convert.ToDouble(inputNumber2);
                }
                
                result = 0.0;
                switch (veiksmas)
                {
                    case "sudetis":
                        result = Addition(number, number2);
                        break;

                    case "atimtis":
                        result = Substraction(number, number2);
                        break;

                    case "daugyba":
                        result = Multiplication(number, number2);
                        break;

                    case "dalyba":
                        result = Division(number, number2);
                        break;

                    case "kelimas laipsniu":
                        result = RaiseDegree(number, number2);
                        break;

                    case "saknis":
                        result = PullRoot(number);
                        break;

                }
                Console.WriteLine("Atsakymas: " + result);
            }
        }

        public static double Addition(double number, double number2)
        {
            return number + number2;
        }

        public static double Substraction(double number, double number2)
        {
            return number - number2;
        }

        public static double Multiplication(double number, double number2)
        {
            return number * number2;
        }

        public static double Division(double number, double number2)
        {
            return number / number2;
        }

        public static double RaiseDegree(double number, double number2)
        {
            return Math.Pow(number, number2);
        }

        public static double PullRoot(double number)
        {
            return Math.Sqrt(number);
        }
    }
}