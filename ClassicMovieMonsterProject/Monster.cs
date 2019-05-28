using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicMovieMonsterProject
{
    class Monster
    {
        //data members
        private string name;
        private int strength;
        private int cunning;
        private int yearofrelease;
        private string actor;
        private string features;
        //properties
        //constructors
        public Monster(string n, int s, int c, int y, string a, string f)
        {
            name = n;
            strength = s;
            cunning = c;
            yearofrelease = y;
            actor = a;
            features = f;
        }
        //methods
        public void Display()
        {
            Console.WriteLine("Monster Name:\t\t{0}\nFeatures:\t\t{1}", name, features);
            Console.WriteLine("Strength:\t\t{0}\nCunning:\t\t{1}", strength, cunning);
            Console.WriteLine("Year of release:\t{0}", yearofrelease);
            Console.WriteLine("Actor:\t\t\t{0}",actor);
            Console.WriteLine("\n");
        }
    }
}
