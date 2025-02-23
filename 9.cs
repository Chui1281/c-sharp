namespace ConsoleApp1;

class Search
{
    private int[] array;
    private int min;
    private int max;

    public Search(int[] array)
    {
        this.array = array;
        min = FindMin();
        max = FindMax();
    }
    public int FindMin()
    {
        int minValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (minValue > array[i]) minValue=array[i];
        }
        return minValue;
    }
    public int FindMax()
    {
        int maxValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (maxValue < array[i]) maxValue=array[i];
        }
        return maxValue;
    }

    public int[] ReplaceArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min) array[i] = 0;
            else if (array[i] == max) array[i] = 99;
        }
        return array;
    }

}
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = null;
        
        while (numbers == null)
        {
            Console.Write("Введите элементы массива через пробел: ");
            string input = Console.ReadLine().Trim(); // Убираем лишние пробелы в начале и конце строки
            
            // Разбиваем строку по пробелам и фильтруем пустые элементы (если между числами несколько пробелов)
            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                numbers = Array.ConvertAll(parts, int.Parse);
            }
            catch
            {
                Console.WriteLine("Ошибка! Введите только числа через пробел.");
                numbers = null;
            }
        }
        Search search = new Search(numbers);
        
        Console.WriteLine($"Min: {search.FindMin()}");
        Console.WriteLine($"Max: {search.FindMax()}");
        Console.WriteLine($"New Array: {string.Join(", ",search.ReplaceArray())}");
    }
}
