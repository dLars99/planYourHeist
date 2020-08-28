using System;
using System.Collections.Generic;

namespace planYourHeist
{
    public class Team
    {
        public string TeamName { get; set; }
        public List<Dirtbag> TeamMembers = new List<Dirtbag>();

        public Team()
        {
            TeamMembers = new List<Dirtbag>();
        }
        public void AddHench()
        {
            Console.WriteLine("Wanna add someone to the gang?");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("What's the dirtbag's name?");
            // Dirtbag Name
            string name = Console.ReadLine();
            // Dirtbag Skill 
            Console.WriteLine();
            Console.WriteLine($"On a scale from 1 to 7 how good is {name}?");
            skill:
                string skillStr = Console.ReadLine();
            bool v = int.TryParse(skillStr, out int skill);

            if (!v || skill < 1 || skill > 7)
            {
                Console.WriteLine($"Fuhgettaboutit! How good is {name}?");
                goto skill;

            }
            //Dirtbag Courage
            Console.WriteLine();
            Console.WriteLine($"How good is {name} in a sticky situation? From... ahhh.. 0.0 to 2.0?");
            courage:
                string courageStr = Console.ReadLine();
            bool w = double.TryParse(courageStr, out double courage);

            if (!w || courage < 0.0 || courage > 2.0)
            {
                Console.WriteLine();
                Console.WriteLine($"Come on Slim, ya killin me here! How good is {name}?");
                goto courage;

            }

            Dirtbag x = new Dirtbag(name, skill, courage);
            Console.WriteLine();
            Console.WriteLine("Ayyy oooh, get that dirtbag an orientation package. He's on the team!");

            TeamMembers.Add(x);

        }

        public void ListMembers()
        {
            Console.WriteLine();
            Console.WriteLine("Here's the squad:");
            foreach (Dirtbag dirtbag in TeamMembers)
            {
                Console.WriteLine($"{TeamMembers.IndexOf(dirtbag) + 1}. {dirtbag.Name} Skill: {dirtbag.SkillLevel} Cool: {dirtbag.Courage}");

            }

        }
    }

}