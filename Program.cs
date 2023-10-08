using System;
using System.Threading;

namespace Stopwatch{
    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("Seja bem-vindo ao Menu!");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 10m = 10 minutos");
            Console.WriteLine("0 = Sair");

            string res = Console.ReadLine().ToLower();
            char type = char.Parse(res.Substring(res.Length - 1, 1)); //Pega o ultimo caractere da string
            int time = int.Parse(res.Substring(0, res.Length - 1)); //Pega todos caracteres da string menos o ultimo
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            
            if (time == 0)
                Environment.Exit(0);

            Start(time * multiplier);
        }

        static void Start(int time){
            int currentTime = 0;
            while(time != currentTime){
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Contador finalizado, voltando pro menu...");
            Thread.Sleep(2500);
            Menu();
        }
    }
}