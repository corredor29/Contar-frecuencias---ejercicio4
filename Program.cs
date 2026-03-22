using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

class Program
{
    class Frecuencia
    {
        public char Car {get; set;}
        public int Veces {get; set;}
    }
    static void Main(string[] args)
    {
        Console.WriteLine("ingrese el texto");
        string Texto = Console.ReadLine() ?? "";
        List<Frecuencia> Resultado = ContarFrecuencia(Texto);
        Console.WriteLine("\nResultado:");
        foreach (var item in Resultado)
        {
            Console.WriteLine ("{ Car = '" + item.Car + "', Veces = " + item.Veces + " }");

        }
    }
    static List<Frecuencia> ContarFrecuencia(string Texto)
    {
        Dictionary<char,int> Conteo = new Dictionary<char, int>();
        string Normalizado = RemoverTildes(Texto.ToLower());
        foreach (char c in Normalizado)
        {
            if (char.IsAsciiLetterOrDigit(c))
            {
                if (Conteo.ContainsKey(c))
                    Conteo[c]++;
                else
                     Conteo[c] =1;
            }
        }
        List<Frecuencia> Resultado = new List<Frecuencia>();
        foreach  (var par in Conteo)
        {
            Resultado.Add(new Frecuencia{ Car =par.Key, Veces = par.Value});
        }
        Resultado.Sort((a,b) => a.Car.CompareTo(b.Car));
        return Resultado;
    }
    static string RemoverTildes(string Texto)
    {
        string Normalizado = Texto.Normalize(NormalizationForm.FormD);
        StringBuilder Resultado = new StringBuilder();
        foreach (char c in Normalizado)
        {
            UnicodeCategory uc = Char.GetUnicodeCategory(c);
            if(uc != UnicodeCategory.NonSpacingMark)
            {
                Resultado.Append(c);
            }
        }
        return Resultado.ToString().Normalize(NormalizationForm.FormC);
    }
}