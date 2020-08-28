using System;
using System.Collections.Generic;

namespace planYourHeist
{
    public class Heist
    {
        public string HeistName { get; set; }
        public string Target { get; set; }
        private int _difficulty { get; set; }
        private int _combinedSkill { get; set; }

        private void getSkill(Team team)
        {
            _combinedSkill = team.CombinedSkill;
        }

        public Heist(string name, string target)
        {
            HeistName = name;
            Target = target;
            _difficulty = 100;
        }

    }
}