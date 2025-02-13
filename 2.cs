//exersize 2
namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int j = 2; j < n+1; j++)
        {
            if (n%j==0)
            {
                Console.WriteLine(j);
                break;
            }
            
        }
    }
}
