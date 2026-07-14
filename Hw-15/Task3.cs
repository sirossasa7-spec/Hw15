using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Hw_15
{
    class Article
    {
        public string Title { get; set; }
        public int Symbols { get; set; }
        public string Preview { get; set; }
    }

    class Magazine
    {
        public string Name { get; set; }

        public List<Article> Articles { get; set; } = new List<Article>();
    }
    internal class Task3
    {
        static void Main()
        {
            Magazine m = new Magazine();

            m.Name = "IT News";

            m.Articles.Add(new Article
            {
                Title = "C#",
                Symbols = 5000,
                Preview = "Основи C#"
            });

            m.Articles.Add(new Article
            {
                Title = "LINQ",
                Symbols = 3500,
                Preview = "Запити LINQ"
            });

            string json = JsonSerializer.Serialize(m);

            File.WriteAllText("magazine.json", json);

            Magazine mag = JsonSerializer.Deserialize<Magazine>(File.ReadAllText("magazine.json"));

            Console.WriteLine(mag.Name);

            foreach (var a in mag.Articles)
            {
                Console.WriteLine($"{a.Title} {a.Symbols}");
            }

            Console.ReadKey();
        }
    }
}
