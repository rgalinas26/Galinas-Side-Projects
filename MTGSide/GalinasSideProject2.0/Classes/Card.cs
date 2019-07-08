using System;
using System.Collections.Generic;
using System.Text;
using GalinasSideProject2._0.Classes;

namespace GalinasSideProject2._0.Classes
{
    public class Card
    {

        public string Name { get; set; }
        public string ManaCost { get; set; }
        public int Power { get; set; }
        public bool IsLand { get; set; }

        public Card(string name, string manaCost, int power, bool isLand)
        {
            this.Name = name;
            this.ManaCost = manaCost;
            this.Power = power;
            this.IsLand = isLand;
        }

    }
}
