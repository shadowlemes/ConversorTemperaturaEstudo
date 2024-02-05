using System;
using System.Threading;

namespace conversorTemperatura
{
    public class Inicio
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao conversor de temperatura.\n");
            Console.WriteLine("1 - Fahrenheit para Celsius\n2 - Fahrenheit para Kelvin\n3 - Celsius para Fahrenheit\n4 - Celsius para Kelvin\n5 - Kelvin para Fahrenheit\n6 - Kelvin para Celsius\n0 - Para sair");
            Console.WriteLine("\n___________________________");

            Console.Write("Digite a opção desejada:");
            var result = short.Parse(Console.ReadLine());

            switch (result)
            {
                case 0: TentativaSaida.Exit(); break;
                case 1: Conversoes.FahrenheitParaCelsius(); break;
                case 2: Conversoes.FahrenheitParaKelvin(); break;
                case 3: Conversoes.CelsiusParaFahrenheit(); break;
                case 4: Conversoes.CelsiusParaKelvin(); break;
                case 5: Conversoes.KelvinParaFahrenheit(); break;
                case 6: Conversoes.KelvinParaCelsius(); break;
                default: Console.WriteLine("Escolha uma opção válida, pressione qualquer tecla e tente novamente."); break;
            }
            //Caso a opção escolhida não seja válida
            TentativaSaida.TenteNovamente();
        }
    }

   public class Conversoes
    {
        public static void FahrenheitParaCelsius()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Fahrenheit para conversão em Celsius:");
            var value = int.Parse(Console.ReadLine());
            var result = (value - 32) * 5 / 9;
            Console.WriteLine($"\nA temperatura {value}Fº, equivale a temperatura de {result}Cº.");
            Console.ReadLine();
            Inicio.Main();
        }

        public static void FahrenheitParaKelvin()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Fahrenheit para conversão em Kelvin:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = (value - 32) * 5 / 9 + 273.15M;
            Console.WriteLine($"\nA temperatura {value}Fº, equivale a temperatura de {result}Kº.");
            Console.ReadLine();
            Inicio.Main();
        }

        public static void CelsiusParaFahrenheit()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Celsius para conversão em Fahrenheit:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = value * 1.8M + 32;
            Console.WriteLine($"\nA temperatura {value}C°, equivale a temperatura de {result}Fº.");
            Console.ReadLine();
            Inicio.Main();
        }

        public static void CelsiusParaKelvin()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Celsius para conversão em Kelvin:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = value + 273.15M;
            Console.WriteLine($"\nA temperatura {value}C°, equivale a temperatura de {result}Kº.");
            Console.ReadLine();
            Inicio.Main();
        }

        public static void KelvinParaFahrenheit()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Kelvin para conversão em Fahrenheit:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = (value - 273.15M) * 9 / 5 + 32;
            Console.WriteLine($"\nA temperatura {value}K°, equivale a temperatura de {result}Fº.");
            Console.ReadLine();
            Inicio.Main();
        }

        public static void KelvinParaCelsius()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Kelvin para conversão em Celsius:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = value - 273.15M;
            Console.WriteLine($"\nA temperatura {value}Kº, equivale a temperatura de {result}Fº.");
            Console.ReadLine();
            Inicio.Main();
        }
    }

    public class TentativaSaida
    {

        public static void TenteNovamente()
        {
            Console.ReadLine();
            Console.Clear();
            Inicio.Main();
        }

        public static void Exit() /*saida aplicação*/
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Obrigado por utilizar esta aplicação");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Feito por Gabriel Lemes de Oliveira");
            Thread.Sleep(1000);
            System.Environment.Exit(0);
        }
    }
}
