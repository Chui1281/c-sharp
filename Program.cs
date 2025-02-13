//exersize 1
namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int i = Convert.ToInt32(Console.ReadLine());
        List<int> array = new List<int>();
        while(i!=0)
        {
            array.Add(i);
            i=Convert.ToInt32(Console.ReadLine());
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