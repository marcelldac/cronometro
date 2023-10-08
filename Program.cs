using System;
using System.Threading;

namespace Stopwatch{
    class Program{
        static void Main(string[] args){
            Start(10);
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
        }
    }
}