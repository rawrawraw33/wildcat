using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace wildcat
{
    internal class Program
    {

        class MainClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Archi:");
                Cat Archi = new Cat("Archi" , 2 );



                Console.WriteLine("Tom:");
                WildCat tom = new WildCat("Tom", 6);

            }
        }



        public class Cat
        {
            private string name;
            private int speed;


            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                }
            }
            public int Speed
            {
                get { return speed; }
                set
                {
                    speed = value;
                }
            }

            public Cat(string name, int speed)
            {
                this.Name = name;
                this.Speed = speed;
            }
            public virtual string SayHi()
            {
                return "Meow";
            }
        }

        public class WildCat : Cat
        {
            private float speed;
            public WildCat(string name, int speed) : base(name, speed)
            {

            }
            public override string SayHi()
            {
                return "Rawr";
            }
        }

    }
}



