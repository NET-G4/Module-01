namespace Lesson02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteMin = byte.MinValue;
            byte byteMax = byte.MaxValue;

            Console.WriteLine($"Byte min: {byteMin}");
            Console.WriteLine($"Byte max: {byteMax}");

            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;

            Console.WriteLine($"Short min: {shortMin}");
            Console.WriteLine($"Short max: {shortMax}");

            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            Console.WriteLine($"Int min: {intMin}");
            Console.WriteLine($"Int max: {intMax}");

            long longMin = long.MinValue;
            long longMax = long.MaxValue;

            Console.WriteLine($"Long min: {longMin}");
            Console.WriteLine($"Long max: {longMax}");

            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;

            Console.WriteLine($"Float min: {floatMin}");
            Console.WriteLine($"Float max: {floatMax}");

            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;

            Console.WriteLine($"Double min: {doubleMin}");
            Console.WriteLine($"Double max: {doubleMax}");
        }
    }
}