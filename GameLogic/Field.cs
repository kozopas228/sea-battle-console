using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameLogic
{
    [Serializable]
    public class Field
    {
        public int Size { get; set; }
        public List<Point> Damaged { get; set; }
        public List<Point> Missed { get; set; }
        public List<Ship> Ships { get; set; }

        public Field()
        {
            this.Ships = new List<Ship>();
            this.Damaged = new List<Point>();
            this.Missed = new List<Point>();
        }
    }
}
