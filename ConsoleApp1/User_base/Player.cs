using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Player : IQuestMember
    {
        public String Name { get; private set; }
        public Damage TotalDamage { get; private set; }
        public Player(String name, Damage damage)
        {
            this.Name = name;
            this.TotalDamage = damage;
        }
    }


}
