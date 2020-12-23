using System;
using System.Linq;

namespace DDD
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.Title = ("Лабораторная работа №9");

            Building t1 = new Building(12);
            t1.Up(22);
            t1.Down(10);
            t1.DrawContent();

            Console.WriteLine("\n");

            Score champ = new Score(26);
            champ.Up(1120);
            champ.Down(34);
            champ.DrawContent();

            Console.ReadKey();
		}
	}
}