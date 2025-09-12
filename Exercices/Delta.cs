using System;

namespace OOP_TP1.Exercices
{
    public static class Delta
    {
        public static void Run()
        {
            Console.WriteLine("Résolution de l'équation du second degré : ax² + bx + c = 0");
            Console.Write("Entrez a : ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("Entrez b : ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("Entrez c : ");
            double c = double.Parse(Console.ReadLine()!);

            double delta = b * b - 4 * a * c;
            Console.WriteLine($"Delta = {delta}");

            if (delta < 0)
            {
                Console.WriteLine("Pas de solution réelle.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Une solution réelle : x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Deux solutions réelles : x1 = {x1}, x2 = {x2}");
            }
        }
    }
}
