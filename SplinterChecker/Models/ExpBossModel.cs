using System;

namespace SplinterChecker.Models

{

    public class ExpBossModel
    {
        public string message { get; set; }
        public Boss boss { get; set; }
    }

    public class Boss
    {
        public object[] effects { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public DateTime spawned { get; set; }
        public DateTime killed { get; set; }
        public object[] battles { get; set; }
        public Standing[] standings { get; set; }
        public string id { get; set; }


    }



    public class Standing
    {
        public int[] reward { get; set; }
        public string _id { get; set; }
        public string player { get; set; }
        public int dmg { get; set; }
        public int fights { get; set; }
    }




}
