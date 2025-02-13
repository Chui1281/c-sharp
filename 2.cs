namespace ConsoleApp1

class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Введите число (не менее 2): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 2)
        {
            Console.WriteLine("Ошибка! Введите целое число не менее 2.");
            Console.Write("Попробуйте снова: ");
        }

        for (int j = 2; j <= n + 1; j++)
        {
            if (n % j == 0)
            {
                Console.WriteLine(j);
                break;
            }
        }
    }
}
