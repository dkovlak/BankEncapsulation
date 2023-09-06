using System.Diagnostics.Metrics;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var user1 = new BankAccount();

            Console.WriteLine("Hello, World! What's your name earthling?");
            var userName = Console.ReadLine();

            Console.WriteLine($"\nHello {userName}!, How much money would you like to deposit today?");

            double userInput = 0;
            bool validInput = false;

            while (!validInput)
            {

                if (double.TryParse(Console.ReadLine(), out userInput) && userInput >= 0)
                {
                    user1.Deposit(userInput);
                    validInput = true;
                }
                else { Console.WriteLine("Error: Please enter only numeric digits. We don't accept smiles as currency!"); }
            }

            Console.WriteLine("\n---------------");
            Console.WriteLine($"Little, but okay! You can choose whatever you want, but I advice you {userName}, to choose '1'");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            while (choice != "4")
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"How much would you like to deposit my {userName}?");
                        if (double.TryParse(Console.ReadLine(), out userInput) && userInput >= 0)
                        {
                            user1.Deposit(userInput);
                            Console.WriteLine($"Great job {userName}. Deposit successful.");
                        }
                        else
                        {
                            Console.WriteLine("Error: Please enter a valid non-negative numeric amount.");
                        }
                        break;

                    case "2":
                        Console.WriteLine($"Dear {userName}, How much would you like to withdraw?");
                        if (double.TryParse(Console.ReadLine(), out userInput) && userInput >= 0)
                        {
                            double withdraw = user1.Withdraw(userInput);
                            if (withdraw >= 0)
                            {
                                Console.WriteLine($"{userName}, withdrawal successful. New balance: {user1.GetBalance()}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Error: {userName}, just enter a valid non-negative numeric amount.");
                        }
                        break;

                    case "3":
                        Console.WriteLine($"{userName}, your current balance: {user1.GetBalance()}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("\n---------------");
                Console.WriteLine($"{userName}, what would you like to do next?");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();
            }
            Console.WriteLine("\n----------------------Time is up-------------------------");
            Console.WriteLine($"Thank you for using our banking services. Have a great day my {userName}!");
        }
    }
}
