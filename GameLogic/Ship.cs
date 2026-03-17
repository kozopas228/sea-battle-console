using System.Collections.Generic;
using System.Drawing;

namespace GameLogic
{
    public enum ShipDirection
    {
        Horizontal,
        Vertical
    }
    public class Ship
    {
        public int Size { get; set; }
        public List<Point> Points { get; set; }
        public ShipDirection Direction { get; set; }
        public int Hp { get; set; }

        public Ship(int size)
        {
            this.Size = size;
            this.Hp = this.Size;
            this.Points = new List<Point>();
        }

        public Ship()
        {
            
        }
    }
}
