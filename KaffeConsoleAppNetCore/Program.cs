using kaffe;
using System;
using System.Collections.Generic;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Cortado c1 = new Cortado();
            Latte l1 = new Latte();
            SortKaffe sk1 = new SortKaffe(5);
            FlatWhite fw1 = new FlatWhite(10);

            Console.WriteLine($"Cortado = Pris: {c1.Pris()}; Rabat: {c1.Rabat}; Styrke: {c1.Styrke()}; MlMælk: {c1.MlMælk()}");
            Console.WriteLine($"Latte = Pris: {l1.Pris()}; Rabat: {l1.Rabat}; Styrke: {l1.Styrke()}; MlMælk: {l1.MlMælk()}");
            Console.WriteLine($"SortKaffe = Pris: {sk1.Pris()}; Rabat: {sk1.Rabat}; Styrke: {sk1.Styrke()}");
            Console.WriteLine($"FlatWhite = Pris: {fw1.Pris()}; Rabat: {fw1.Rabat}; Styrke: {fw1.Styrke()}; MlMælk: {fw1.MlMælk()}");

            List<Kaffe> Kaffer = new List<Kaffe>() { c1, l1, sk1, fw1 };
            List<Imælk> MælkeDrikke = new List<Imælk>() {c1, l1, fw1};

            foreach (Kaffe k in Kaffer)
            {
                if (k is Latte l)
                {
                    Console.WriteLine($"{l.GetType().Name} = pris: {l.Pris()}; mlMælk: {l.MlMælk()}");
                }
            }

            Console.ReadKey();
        }
    }
}
