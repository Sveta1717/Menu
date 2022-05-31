using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        delegate void Menu();
        static void NewGame() => Console.WriteLine("Ласкаво просимо до гри!\n");
        static void LoadGame()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("*");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
        static void Specification() => Console.WriteLine("Завдання гри просте – вбивати москалiв\n");
        static void About_Author() => Console.WriteLine("Україна понад усе!\n");
        static void Exit()
        {
            Console.WriteLine("До побачення! Повертайтеся живими!\n");
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Зробить свiй вибiр\n");
            Console.WriteLine("1 Нова гра\n2 Завантажити гру\n3 Правила\n4 Про автора\n0 Вихiд");
            Menu menu;
            do
            {
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:                       
                        menu = NewGame;
                        menu();
                        break;
                    case 2:                        
                        menu = LoadGame;
                        menu();
                        break;
                    case 3:                       
                        menu = Specification;
                        menu();
                        break;
                    case 4:                        
                        menu = About_Author;
                        menu();
                        break;
                    case 0:                        
                        menu = Exit;
                        menu();
                        return;
                    default:
                        Console.WriteLine("Помилка");
                        break;
                }
            } while (true);        
        }
    }
}
