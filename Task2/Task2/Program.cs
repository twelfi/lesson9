namespace Task2;

internal class Program
{
    static void Main(string[] args)
    {
        var products = new Dictionary<string, double>
        {
            {"Apple", 2.11 },
            {"Banana", 4.15 },
            {"Orange", 3.18 }
        };

        products["Kiwi"] = 5.61;

        foreach (var product in products)
            {
                Console.WriteLine($"{product.Key}: {product.Value} $");
            }

        Console.WriteLine("Введите продукт для поиска:");
        var find = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(find))
        {
            Console.WriteLine("Некорректное значение");
            find = Console.ReadLine();
        }

        if (products.ContainsKey(find))
        {
            double price = products[find];
            Console.WriteLine($"{price}$");
        }
        else Console.WriteLine("Продукт не найден");

        var keys = products.Keys.ToList();
        foreach (var key in keys)
        {
            products[key] *= 1.1;
        }

        Console.WriteLine("Цена, увеличенная на 10%:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Key}: {product.Value} $");
        }
    }
}
