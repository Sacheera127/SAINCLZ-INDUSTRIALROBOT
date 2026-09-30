using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._1
{
    public class servicerobot : roboprototype
    {
        public String Servicetask;
        public servicerobot(String Modelname, String Batterycapacity, String Softwareversion, String Servicetask)
            : base(Modelname, Batterycapacity, Softwareversion)
        {
            this.Servicetask = Servicetask;
        }
        public override roboprototype Clone()
        {
            return new servicerobot(this.Modelname, this.Batterycapacity, this.Softwareversion, this.Servicetask);
        }
        public override void Display()
        {
            Console.WriteLine("Model Name: " + this.Modelname);
            Console.WriteLine("Battery Capacity: " + this.Batterycapacity);
            Console.WriteLine("Software Version: " + this.Softwareversion);
            Console.WriteLine("Service Task: " + this.Servicetask);
        }
    }
}
