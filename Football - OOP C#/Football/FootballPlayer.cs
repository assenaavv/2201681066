using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class FootballPlayer:Person
    {
        private string name;
        private int number;
        private int age;
        private double height;

        public string Name
        {   get { return name; } 
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public FootballPlayer(string name, int number, int age, double height) : base(name,age )

        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
        }

    }
}
