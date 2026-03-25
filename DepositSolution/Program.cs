using DepositApp;

internal class Program
{
    private static void Main(string[] args)
    {
        
            var calculator = new DepositCalculator();

            Console.Write("Введите сумму: ");
            decimal sum = decimal.Parse(Console.ReadLine());

            Console.Write("Введите процент (например 0.1 для 10%): ");
            decimal rate = decimal.Parse(Console.ReadLine());

            Console.Write("Введите срок (в годах): ");
            int years = int.Parse(Console.ReadLine());

            decimal result = calculator.Calculate(sum, rate, years);

            Console.WriteLine($"Итоговая сумма: {result}");
        
    }
}