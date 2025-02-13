//exersize 1
namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int i;
        List<int> array = new List<int>();
        while(true)
        {
            if (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Введите целое число");
                continue;
            }

            if (i == 0) break;
            array.Add(i);
        }

        if (array.Count < 1)
        {
            Console.WriteLine("Введите хотя бы 1 элемент");
        }
        int result=0;
        int  count = 1;
        for (int j = 0; j < ((array.Count) - 1); j++)
        {
            if (array[j] == array[j + 1])
            {
                count++;
            }
            else
            {
                result=Math.Max(result, count);
                count = 1;
            }
            
        }
        result=Math.Max(result, count);
        Console.WriteLine(result);
    }
}
