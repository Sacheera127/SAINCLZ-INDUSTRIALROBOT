using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._1
{
    public class industrialrobot : roboprototype
    {
        public String industrialtask;

        public industrialrobot(String Modelname, String Batterycapacity, String Softwareversion, String industrialtask)
            : base(Modelname, Batterycapacity, Softwareversion)
        {
            this.industrialtask = industrialtask;
        }

        public override roboprototype Clone()
        {
            return new industrialrobot(this.Modelname, this.Batterycapacity, this.Softwareversion, this.industrialtask);
        }

        public override void Display()
        {
            Console.WriteLine("Model Name: " + this.Modelname);
            Console.WriteLine("Battery Capacity: " + this.Batterycapacity);
            Console.WriteLine("Software Version: " + this.Softwareversion);
            Console.WriteLine("Industrial Task: " + this.industrialtask);
        }
    }
}
