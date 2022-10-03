using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {         
            int magicDamage,physicalDamage;

            Console.WriteLine("Type physical and magic damage in order:");
            physicalDamage = Convert.ToInt32(Console.ReadLine());  
            magicDamage = Convert.ToInt32(Console.ReadLine());

            List<IQuestMember> questMembers = new List<IQuestMember>();
            
            Player conan = new Player("Conan", new Damage(physicalDamage, magicDamage));
            Player gandalf = new Player("Gandalf", new Damage(physicalDamage, magicDamage));

            
            physicalDamage = Convert.ToInt32(Console.ReadLine());
            magicDamage = Convert.ToInt32(Console.ReadLine());

            Party monotim = new Party("Mono Tim");
            monotim.AddMember(new Player("Newbie", new Damage(physicalDamage, magicDamage)));


            physicalDamage = Convert.ToInt32(Console.ReadLine());
            magicDamage = Convert.ToInt32(Console.ReadLine());

            Party mages = new Party("Mages");
            mages.AddMember(new Player("Minion", new Damage(physicalDamage, magicDamage)));

            monotim.AddMember(mages);
            questMembers.Add(conan);
            questMembers.Add(gandalf);
            questMembers.Add(monotim);

            Damage totalDamage = new Damage();
            foreach (IQuestMember member in questMembers)
            {
                totalDamage += member.TotalDamage;
                Console.WriteLine(member.Name);
            }
            Console.WriteLine("Total damage done:" + totalDamage);
        } 

        
    }
}


