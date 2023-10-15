using System.Diagnostics;
using System.Text;

namespace Lesson05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunWithString();
            RunWithStringBuilder();
        }

        static void RunWithString()
        {
            Stopwatch stopwatch = new Stopwatch();
            string str = "";

            stopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                str += i.ToString();
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }

        static void RunWithStringBuilder()
        {
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder builder = new StringBuilder();

            stopwatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                builder.Append(i.ToString());
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}