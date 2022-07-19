
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elements = 30;
            int[] numbers = new int[elements];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)  // Вывод массива
            {
                numbers[i] = random.Next(elements);
                Console.Write(numbers[i] + ",");
            }

                if (numbers[0] > numbers[1])
                {
                    Console.WriteLine("\nКрайний максимум" + numbers[0]);
                }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] < numbers[i] && numbers[i] > numbers[i+1])
                {
                    Console.WriteLine("\nКрайний максимум" + numbers[i]);
                }
                
            }
        }

    }
}

