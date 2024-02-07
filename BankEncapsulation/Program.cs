namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var depositAmount = double.Parse(Console.ReadLine());

            account1.Deposit(depositAmount);


            Console.WriteLine($"You have deposited ${depositAmount}. Your balance is now ${account1.GetBalance()}");
        }
    }
}
