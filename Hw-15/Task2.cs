using System;
using System.IO;
using System.Text.Json;

namespace Hw_15
{
    class Magazine
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public DateTime Date { get; set; }
        public int Pages { get; set; }
    }
    internal class Task2
    {
        static void Main()
        {
            Magazine m = new Magazine();

            Console.Write("Назва: ");
            m.Name = Console.ReadLine();

            Console.Write("Видавництво: ");
            m.Publisher = Console.ReadLine();

            Console.Write("Кількість сторінок: ");
            m.Pages = int.Parse(Console.ReadLine());

            m.Date = DateTime.Now;

            string json = JsonSerializer.Serialize(m);

            File.WriteAllText("magazine.json", json);

            Magazine mag = JsonSerializer.Deserialize<Magazine>(File.ReadAllText("magazine.json"));

            Console.WriteLine("\nЖурнал");

            Console.WriteLine(mag.Name);
            Console.WriteLine(mag.Publisher);
            Console.WriteLine(mag.Date);
            Console.WriteLine(mag.Pages);

            Console.ReadKey();
        }
    }
}
