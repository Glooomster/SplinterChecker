using System;

namespace SplinterChecker.Models
{


    public class BossModel
    {
        public Stats stats { get; set; }
        public Ogstats ogStats { get; set; }
        public object[] effects { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public DateTime spawned { get; set; }
        public object killed { get; set; }
        public object[] battles { get; set; }
        public object[] standings { get; set; }
        public string id { get; set; }
    }

    public class Stats
    {
        public string[] abilities { get; set; }
        public int mana { get; set; }
        public int attack { get; set; }
        public int ranged { get; set; }
        public int magic { get; set; }
        public int armor { get; set; }
        public int health { get; set; }
        public int speed { get; set; }
    }

    public class Ogstats
    {
        public string[] abilities { get; set; }
        public int mana { get; set; }
        public int attack { get; set; }
        public int ranged { get; set; }
        public int magic { get; set; }
        public int armor { get; set; }
        public float health { get; set; }
        public int speed { get; set; }
    }



}
