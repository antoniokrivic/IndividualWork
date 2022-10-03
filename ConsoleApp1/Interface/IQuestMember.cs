using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IQuestMember
    {
        String Name { get; }
        Damage TotalDamage { get; }
    }
}
