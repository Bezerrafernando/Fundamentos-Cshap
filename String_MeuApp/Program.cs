using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.Clear();
            aula0();
            aula1();
            aula2();
            aula3();
            aula4();
            aula5();
            aula6();
            aula7();
            aula8();
            aula9();
            aula10();
            aula11();
            aula12();
            aula13();
            aula14();
            aula15();
            aula16();

        }
        static void aula0()
        {
            Console.WriteLine("Aula0 : Resultado abaixo \n ");
            var texto = "Testando " + " ";
            var texto2 = $"Testando {texto}";
            var texto3 = $"Testando {1 + 1}";
            var texto4 = @"\Testando \\";
            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.WriteLine(texto3);
            Console.WriteLine(texto4);
            Console.WriteLine("");

        }
        static void aula1()
        {
            Console.WriteLine("Aula1 : Resultado abaixo \n");

            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando")); // Retorna 1 - Verdadeiro
            Console.WriteLine(texto.CompareTo("testando")); // Retorna 0
            Console.WriteLine(texto.CompareTo("")); // Retorna 0
            Console.WriteLine(texto.CompareTo(null)); // Retorna 0
            Console.WriteLine("");

        }
        static void aula2()
        {
            Console.WriteLine("Aula2 : Resultado abaixo \n");
            var texto = "Este é um texto do teste";
            Console.WriteLine(texto.Contains("teste")); // True
            Console.WriteLine(texto.Contains("Teste")); // false
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // True
           // Console.WriteLine(texto.Contains(null)); // Erro
            Console.WriteLine("");


        }
        static void aula3()
        {
            Console.WriteLine("Aula3 : Resultado abaixo \n");
            var texto = "Este é um texto teste";
            Console.WriteLine(texto.StartsWith("Este")); // True
            Console.WriteLine(texto.StartsWith("este")); // false
            Console.WriteLine(texto.StartsWith("Este", StringComparison.OrdinalIgnoreCase)); // True

            Console.WriteLine(texto.EndsWith("Teste")); // false
            Console.WriteLine(texto.EndsWith("teste")); // true
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase)); // true
            Console.WriteLine("");

        }
        static void aula4()
        {
            Console.WriteLine("Aula4 : Resultado abaixo \n");
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Equals("Este texto é um texto de teste")); // True
            Console.WriteLine(texto.Equals("este texto é um texto de teste")); // false
            Console.WriteLine(texto.Equals("este texto é um texto de teste", StringComparison.OrdinalIgnoreCase)); // True
            System.Console.WriteLine("");
        }
        static void aula5()
        {
            Console.WriteLine("Aula5 : Resultado abaixo \n");
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
            Console.WriteLine("");
        }
        static void aula6()
        {
            Console.WriteLine("Aula6 : Resultado abaixo \n");
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine("");

        }
        static void aula7()
        {
            Console.WriteLine("Aula7 : Resultado abaixo \n");
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Insert(5, "AQUI "));
            System.Console.WriteLine("");
        }
        static void aula8()
        {
            Console.WriteLine("Aula8 : Resultado abaixo \n");
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Length);
            System.Console.WriteLine("");

        }
        static void aula9()
        {
            Console.WriteLine("Aula9 : Resultado abaixo \n");
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Remove(0, 5));
            System.Console.WriteLine("");
        }
        static void aula10()
        {
            Console.WriteLine("Aula10 : Resultado abaixo \n");
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Replace("Este", "Isto"));
            Console.WriteLine(texto.Replace("texto", "exemplo"));
            System.Console.WriteLine("");
        }
        static void aula11()
        {
            Console.WriteLine("Aula11 : Resultado abaixo \n");
            var texto = "Este é um texto, de teste";
            var divisao = texto.Split(',');
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            // Console.WriteLine(divisao[2]); // ERRO
            System.Console.WriteLine("");
        }
        static void aula12()
        {
            Console.WriteLine("Aula12 : Resultado abaixo \n");
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Substring(0, 5));
            Console.WriteLine(texto.Substring(texto.LastIndexOf(" ") + 1, 5));
            System.Console.WriteLine("");
        }
        static void aula13()
        {
            Console.WriteLine("Aula13 : Resultado abaixo \n");
            var texto = "Este é           um texto de teste";
            Console.WriteLine(texto.Trim());
            texto = "       Este é um texto de teste             ";
            Console.WriteLine(texto.Trim());
            System.Console.WriteLine("");
        }
        static void aula14()
        {
            Console.WriteLine("Aula14 : Resultado abaixo \n");
            var texto = new StringBuilder();
            texto.Append("Este");
            texto.Append("é");
            texto.Append("um");
            texto.Append(Environment.NewLine);
            texto.Append("texto");
            Console.WriteLine(texto.ToString());
            System.Console.WriteLine("");
        }
        static void aula15()
        {
            Console.WriteLine("Aula15 : Resultado abaixo \n");
            // https://regexr.com/
            var regex = new Regex(@"([0-9])\w+");
            Console.WriteLine(regex.IsMatch("Este é um texto de teste"));
            Console.WriteLine(regex.IsMatch("Este 25 um texto de teste"));
            System.Console.WriteLine("");
        }
        static void aula16()
        {
            Console.WriteLine("Aula16 : Resultado abaixo \n");

            Console.WriteLine(
              string.Compare(
                  "texto",
                  "texto"));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "Isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreNonSpace));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreNonSpace));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreSymbols));
        }

    }
}