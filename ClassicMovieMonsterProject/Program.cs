using System;

namespace ClassicMovieMonsterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster Frank = new Monster("Frankenstein's Monster", 97, 12, 1931, "Boris Karloff", "Golem");
            Frank.Display();

            Monster Dracula = new Monster("Dracula", 80, 80, 1931, "Bela Lugosi","Undead parasite");
            Dracula.Display();

            Monster Wolfie = new Monster("The Wolfman", 90, 30, 1941, "Lon Chaney Jr", "Lycanthrope");
            Dracula.Display();

            Monster Phantom = new Monster("The Phantom of the Opera", 44, 79, 1925, "Lon Chaney", "Manipulation");
            Phantom.Display();

            Monster Hyde = new Monster("Dr. Jekyll and Mr. Hyde", 97, 15, 1913, "King Baggot","Metamorphosis");
            Hyde.Display();
        }
    }
}
