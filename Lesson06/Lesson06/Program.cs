namespace Lesson06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder stringBuilder = new StringBuilder("True c#", 50);

            string input = Console.ReadLine();

            //if (input.Contains("rt"))
            //{
            //    Console.WriteLine("Correct input");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect input");
            //}

            //if (input.StartsWith("qw"))
            //{
            //    Console.WriteLine("Starts with qw");
            //}
            //else
            //{
            //    Console.WriteLine("Does not start with qw");
            //}

            //if (input.EndsWith("ty"))
            //{
            //    Console.WriteLine("Ends with ty.");
            //}

            // ! Bunday qilma boriga shukr qil
            //bool endsWith = true;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (i == input.Length - 2 && input[i] != 't')
            //    {
            //        endsWith = false;
            //        break;
            //    }

            //    if (i == input.Length - 1 && input[i] != 'y')
            //    {
            //        endsWith = false;
            //    }
            //}

            //if (endsWith)
            //{
            //    Console.WriteLine("Your input ends with ty.");
            //}
            //else
            //{
            //    Console.WriteLine("Your input does not end with ty.");
            //}

            //string title = input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower();
            //Console.WriteLine(title);

            // string[] strings = input.Split(',');

            //foreach (string s in strings)
            //{
            //    Console.WriteLine(s);
            //}

            // string joined = string.Join('u', strings);

            // Console.WriteLine(joined);

            //StringBuilder newString = new StringBuilder(100);
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        newString.Append(input.Substring(0, 1).ToUpper());
            //    }
            //    else if (input[i - 1] == ' ')
            //    {
            //        newString.Append(input.Substring(i, 1).ToUpper());
            //    }
            //    else
            //    {
            //        newString.Append(input.Substring(i, 1).ToLower());
            //    }
            //}

            //string[] strings = input.Split('.');

            //for (int i = 0; i < strings.Length; i++)
            //{
            //    if (strings[i].Length > 1)
            //    {
            //        strings[i] =
            //            strings[i].Substring(0, 1).ToUpper() +
            //            strings[i].Substring(1).ToLower();
            //    }
            //}

            // string text = string.Join('.', strings);

            bool isNumber = true;

            //if (char.IsNumber(input, 0))
            //{
            //    Console.WriteLine("It is number");
            //}
            //else
            //{
            //    Console.WriteLine("It is not number");
            //}

            //if (input.All(char.IsDigit))
            //{
            //    Console.WriteLine("It is number");
            //}
            //else
            //{
            //    Console.WriteLine("It is not number");
            //}

            //if (input.Any(char.IsDigit))
            //{
            //    Console.WriteLine("It has a number");
            //}
            //else
            //{
            //    Console.WriteLine("It doesn't have any number.");
            //}

            //Console.WriteLine(input.TrimStart());
            //Console.WriteLine(input.TrimEnd());
            //Console.WriteLine(input.Trim());

            input = input.Replace("l", "");
            input = input.Replace("L", "");

            Console.WriteLine(input);
            //string str = "abc";
            //string str1 = "abc";
            //string str2 = new string("abc");
            //string str3 = new string("abc");

            //if (ReferenceEquals(str, str1))
            //{
            //    Console.WriteLine("str == str1");
            //}

            //if (ReferenceEquals(str, str2))
            //{
            //    Console.WriteLine("str == str2");
            //}

            //if (ReferenceEquals(str2, str3))
            //{
            //    Console.WriteLine("str2 == str3");
            //}

            Main(args);
        }
    }
}