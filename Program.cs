namespace Real_BankMaskin_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankKonto mariabankkonto = new BankKonto(123456789, 3333);

            Console.Write("Enter your pinkod please");
            int pinkod = Convert.ToInt32(Console.ReadLine());

            if (pinkod == mariabankkonto.Pinkod)
            {
                Console.WriteLine("Welcome to your account");
                Console.WriteLine("Press (1) to look at your balalenc");
                Console.WriteLine("Press (2) to take out money");
                Console.WriteLine("Press (3) to put in money");
                String val = Console.ReadLine();

                if (val == "1")
                {
                    Console.WriteLine($"Ditt saldo är {mariabankkonto.CheckBalance()}");
                }

                if (val == "2")
                {
                    Console.WriteLine("How much money do you wnat to take out?");
                    String val2 = Console.ReadLine();
                    Console.WriteLine($"{val2} kr togs ut ur ditt konto");
                }

                if (val == "3")
                {
                    Console.WriteLine("How much money do you want to put into your account?");
                    String val3 = Console.ReadLine();
                    Console.WriteLine($"{val3} kr got added to your account");
                }
                else
                {
                    Console.WriteLine("Fel pinkod");
                }

            }
        }
    }
}