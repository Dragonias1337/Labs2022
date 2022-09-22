using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Pupil
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();

    }

    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"{Name} finished the semester without any tails");
        }
        public override void Read()
        {
            Console.WriteLine($"{Name} reads recomended literature");
        }
        public override void Write()
        {
            Console.WriteLine($"{Name} writes down all lectures");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Name} relaxes in O'Hara");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"{Name} finished the semester with some tails");
        }
        public override void Read()
        {
            Console.WriteLine($"{Name} reads toolkits from library");
        }
        public override void Write()
        {
            Console.WriteLine($"{Name} writes down most lectures");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Name} relaxes in Sito-Piano");
        }
    }
    class BadPupil: Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"{Name} goes to akadem!");
        }
        public override void Read()
        {
            Console.WriteLine($"{Name} reads only memes!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Name} writes down nothing!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Name} relaxes in Zinziver!");
        }
    }

 





    
}
