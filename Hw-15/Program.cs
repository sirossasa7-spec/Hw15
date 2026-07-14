using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Hw_15
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            List<Fraction> fractions = new List<Fraction>();

            Console.Write("Скільки дробів? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Fraction f = new Fraction();

                Console.Write("Чисельник: ");
                f.Numerator = int.Parse(Console.ReadLine());

                Console.Write("Знаменник: ");
                f.Denominator = int.Parse(Console.ReadLine());

                fractions.Add(f);
            }

            string json = JsonSerializer.Serialize(fractions);

            File.WriteAllText("fractions.json", json);

            Console.WriteLine("Збережено!");

            string text = File.ReadAllText("fractions.json");

            List<Fraction> list = JsonSerializer.Deserialize<List<Fraction>>(text);

            Console.WriteLine("Завантажено:");

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Numerator}/{item.Denominator}");
            }

            Console.ReadKey();
        }
    }
}