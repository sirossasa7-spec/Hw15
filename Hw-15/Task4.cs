using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Hw_15
{
    class Magazine
    {
        public string Name { get; set; }
        public int Pages { get; set; }
    }
    internal class Task4
    {
        static void Main()
        {
            List<Magazine> magazines = new List<Magazine>()
            {
                new Magazine{ Name="IT News", Pages=120},
                new Magazine{ Name="Sport", Pages=80},
                new Magazine{ Name="Science", Pages=150}
            };

            string json = JsonSerializer.Serialize(magazines);

            File.WriteAllText("magazines.json", json);

            List<Magazine> list =
                JsonSerializer.Deserialize<List<Magazine>>(File.ReadAllText("magazines.json"));

            foreach (var m in list)
            {
                Console.WriteLine($"{m.Name} - {m.Pages}");
            }

            Console.ReadKey();
        }
    }
}
