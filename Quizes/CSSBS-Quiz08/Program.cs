using System;

namespace CSSBS_Quiz08
{
    class Program
    {
        static void Main(string[] args)
        {
            Firearm Pistol = new Firearm("Pistol", "Pop", "9mm");
            Console.WriteLine(Pistol.ToString());
            Firearm Rifle = new Firearm("Rifle", "bang", "5.56");
            Console.WriteLine(Rifle.ToString());
            Firearm Shotgun = new Firearm("Shotgun", "Pop", "12 gauge");
            Console.WriteLine(Shotgun.ToString());
        }
    }
    internal class Firearm
    {
        private static int Count { get; set; } = 0;
        string Name { get; set; }
        string Sound { get; set; }
        string Caliber { get; set; }
        public Firearm(string Name, string Sound, string Caliber)
        {
            this.Name = Name;
            this.Sound = Sound;
            this.Caliber = Caliber;
            Count++;
        }
        public override string ToString()
        {
            return $"I am a {Name} and I go {Sound} with a {Caliber} round, and we have {Count} Firearms";
        }
    }
}
