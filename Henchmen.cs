using System;

namespace planYourHeist
{
    public class Dirtbag
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double Courage { get; set; }

        public Dirtbag(string name, int skill, double courage)
        {
            Name = name;
            SkillLevel = skill;
            Courage = courage;
        }
    }
}