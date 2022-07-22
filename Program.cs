using System;
namespace Cspassgen
{
    class Program
    {
        static void Main(string[] args)
        {

            GeneratePassword.Generate();
        }
    }

    public static class GeneratePassword
    {
        private static string qLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string qDigits = "1234567890";
        private static string qChars = "!\"#$%&'()*+,-./:;<=>?@[]^_`{|}~";

        public static void Generate(bool restart = true, int qLength = 8)
        {
            while (restart == true)
            {
                Console.WriteLine($"Input the desired length: (Current:{qLength})\t");
                try { qLength = Convert.ToInt32(Console.ReadLine()); } catch { }
                string qString = $"{qLetters}{qLetters.ToLower()}{qDigits}{qChars}";
                char[] pwd = new char[qLength];
                Random rand = new Random();
                for (int xd = 0; xd < qLength; xd++)
                {
                    pwd[xd] = qString[rand.Next(qString.Length - 1)];
                }
                Console.WriteLine(":\t" + string.Join(null, pwd) + "\n: Restart?: [Y]es\t[N]o");
                if (Console.ReadLine() == "n")
                {
                    restart = false;
                }
            }
        }
    }
}