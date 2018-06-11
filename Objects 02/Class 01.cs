using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Batman = new Hero
            {
                SecretName = "Pesho",
                HeroName = "Batman",
                HeroStrength = 26

            };

            Hero Terminator = new Hero
            {
                SecretName = "Arnold Schwarzengger ",
                HeroName = "Terminator",
                HeroStrength = 148
            };
            List<Hero> heroes = new List<Hero>();
            heroes.Add(Batman);
            heroes.Add(Terminator);
            foreach (Hero hero in heroes)
            {
                Console.WriteLine(hero.HeroName + " = " + hero.HeroStrength);
            }
        }
    }
    class Hero
    {
        public string SecretName { get; set; }
        public string HeroName { get; set; }
        public int HeroStrength { get; set; }
    }
}
