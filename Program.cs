using System;
using System.Threading;

namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("\tBem vindo ao Cronômetro");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Quanto tempo deseja contar? \nS = Segundos > 10s = 10 Segundos\nM = Minuto > 1m = 1 Minuto");

      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));
      int multiplier = 1;

      if (type == 'm')
        multiplier = 60;

      if (time == 0)
        System.Environment.Exit(0);

      PreStart(time * multiplier);
    }

    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set..");
      Thread.Sleep(1000);
      Console.WriteLine("GO!");
      Thread.Sleep(2000);

      Start(time);
    }

    static void Start(int time)
    {
      int currentTime = 0;
      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("StopWatch finalizado");
      Thread.Sleep(2000);
      Menu();
    }
  }
}