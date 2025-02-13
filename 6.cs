namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Введите число: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Ошибка! Введите целое число.");
            Console.Write("Попробуйте снова: ");
        }
        
        string str = Math.Abs(n).ToString();
        bool chek = true;
        for (int c = 0; c < str.Length - 1; c++)
        {
            if (str[c] != str[c + 1])
            {
                Console.WriteLine("Введённое число не состоит из одинаковых цифр");
                chek = false;
                break;
            }
        }
        if (chek)
        {
            Console.WriteLine("Введённое число состоит из одинаковых цифр");
        }
    }
}
