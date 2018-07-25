using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            MyWorld myWorld = new MyWorld(size);
            myWorld.Draw();
            bool exit = true;
            do
            {
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                switch (consoleKey.Key)
                {
                    case ConsoleKey.DownArrow:
                        myWorld.GoDown();
                        break;

                    case ConsoleKey.UpArrow:
                        myWorld.GoUp();
                        break;
                    case ConsoleKey.LeftArrow:
                        myWorld.GoLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        myWorld.GoRight();
                        break;
                    default:
                        Console.Write("Use only DownArrow,UpArrow,LeftArrow,RightArrow keys");
                        break;
                }
            }
            while (exit);
            Console.ReadLine();
        }


    }
}     
            
    




