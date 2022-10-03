using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Party : IQuestMember
    {
        List<IQuestMember> partyMembers;
        public String Name { get; private set; }
        public Party(String name)
        {
            this.partyMembers = new List<IQuestMember>();
            this.Name = name;
        }
        public void AddMember(IQuestMember member)
        {
            this.partyMembers.Add(member);
        }
        public Damage TotalDamage
        {
            get
            {
                Damage totalDamage = new Damage();
                foreach (IQuestMember member in this.partyMembers)
                {
                    totalDamage += member.TotalDamage;
                }
                return totalDamage;
            }
        }
    }
}
