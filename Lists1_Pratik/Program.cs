using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> davetliler = new List<string>
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        Console.WriteLine("** Davetliler **");

        // foreach ile yazdırma
        int sira = 1;
        foreach (var kisi in davetliler)
        {
            Console.WriteLine($"{sira} - {kisi}");
            sira++;
        }
    }
}
