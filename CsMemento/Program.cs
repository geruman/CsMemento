using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CsMemento
{
    //ATENCION SE DEBE AGREGAR LA REFERENCIA A ENSAMBLADOR SYSTEM.DRAWING PARA QUE FUNCIONE.
    class Program
    {
        static void Main(string[] args)
        {
            
            GameOriginator game = new GameOriginator();
            CareTaker careTaker = new CareTaker();
            Console.WriteLine(game);
            careTaker.SaveMemento(game.CreateMemento());
            Console.WriteLine("Memento 0 created");
            game.PlayerPosition = new Point(20, 30);
            game.Health = 25;
            Console.WriteLine("New game data");
            Console.WriteLine(game);
            careTaker.SaveMemento(game.CreateMemento());
            Console.WriteLine("Memento 1 created");
            game.PlayerPosition = new Point(-10, 23);
            game.Health = 4;
            Console.WriteLine("New game data");
            Console.WriteLine(game);
            careTaker.SaveMemento(game.CreateMemento());
            Console.WriteLine("Memento 2 created");
            Console.WriteLine("Load data 0");
            game.SetMemento(careTaker.GetMemento(0));
            Console.WriteLine(game);
            Console.WriteLine("Load data 1");
            game.SetMemento(careTaker.GetMemento(1));
            Console.WriteLine(game);
            Console.WriteLine("Load data 2");
            game.SetMemento(careTaker.GetMemento(2));
            Console.WriteLine(game);
            Console.ReadKey();



        }
    }
}
