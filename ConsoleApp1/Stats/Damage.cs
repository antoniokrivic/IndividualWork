using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Damage
    {
        public int Physical { get; set; }
        public int Magical { get; set; }
        public Damage() { }
        public Damage(int physical, int magical)
        {
            this.Physical = physical;
            this.Magical = magical;
        }
        public static Damage operator +(Damage lhs, Damage rhs)
        {
            return new Damage(lhs.Physical + rhs.Physical, lhs.Magical + rhs.Magical);
        }
        public override string ToString()
        {
            return "Physical damage:" + this.Physical + ", Magic damage:" + this.Magical;
        }
    }
}
