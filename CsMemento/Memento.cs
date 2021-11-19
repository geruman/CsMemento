using System.Drawing;

namespace CsMemento
{
    public class Memento
    {
        private Point playerPosition;
        private int health;

        public Memento(Point playerPosition, int health)
        {
            this.playerPosition = new Point(playerPosition.X,playerPosition.Y);
            this.health = health;
        }
        public int GetHealth()
        {
            return health;
        }
        public Point GetPlayerPosition()
        {
            return playerPosition;
        }
    }
}