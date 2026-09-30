using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._1
{
    public class entertainmentrobot : roboprototype
    {
        public String EntertainmentType;
        public entertainmentrobot(String Modelname, String Batterycapacity, String Softwareversion, String EntertainmentType)
            : base(Modelname, Batterycapacity, Softwareversion)
        {
            this.EntertainmentType = EntertainmentType;
        }
        public override roboprototype Clone()
        {
            return new entertainmentrobot(this.Modelname, this.Batterycapacity, this.Softwareversion, this.EntertainmentType);
        }
        public override void Display()
        {
            Console.WriteLine("Model Name: " + this.Modelname);
            Console.WriteLine("Battery Capacity: " + this.Batterycapacity);
            Console.WriteLine("Software Version: " + this.Softwareversion);
            Console.WriteLine("Entertainment Type: " + this.EntertainmentType);
        }
    }
}
