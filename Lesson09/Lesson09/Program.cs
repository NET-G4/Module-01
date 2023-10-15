namespace Lesson09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, };
            FindMinMaxValues(array, out int minValue, out int maxValue);

            Console.WriteLine($"Min value: {minValue}");
            Console.WriteLine($"Max value: {maxValue}");
        }

        public static async Task Calculate()
        {
            int a = await GetValueA();
            int b = await GetValueB();
            int c = await GetValueC();

            return a + b + c;
        }

        public static async Task GetValue()
        {
            return await Calculate();
        }
    }
}