using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CsMemento
{
    public class GameOriginator
    {
        public Point PlayerPosition { get; set; }
        public int Health { get; set; }
        public GameOriginator()
        {
            PlayerPosition = new Point(0, 0);
            Health = 10;
        }
        public Memento CreateMemento()
        {
            return new Memento(PlayerPosition, Health);
        }
        public void SetMemento(Memento restore)
        {
            PlayerPosition = new Point(restore.GetPlayerPosition().X,restore.GetPlayerPosition().Y);
            Health = restore.GetHealth();
        }
        public override string ToString()
        {
            return "Game data: { Player position:[x: "+PlayerPosition.X+" y: "+PlayerPosition.Y+"], player health:"+Health+"}";
        }
    }
}
