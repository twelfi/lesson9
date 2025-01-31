using System.Text.RegularExpressions;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Некорректное значение");
                text = Console.ReadLine();
            }
            string[] words = Regex.Split(text.ToLower(), @"\W+");

            Dictionary<string, int> rate = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (rate.ContainsKey(word))
                {
                    rate[word]++;
                }
                else
                {
                    rate[word] = 1;
                }
            }

            Console.WriteLine("Частота слов:");
            foreach (var pair in rate)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
