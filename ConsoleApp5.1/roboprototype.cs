using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._1
{
    public abstract class roboprototype
    {
        public String Modelname, Batterycapacity, Softwareversion;

        public roboprototype(String Modelname, String Batterycapacity, String Softwareversion)
        {
            this.Modelname = Modelname;
            this.Batterycapacity = Batterycapacity;
            this.Softwareversion = Softwareversion;
        }
        public abstract roboprototype Clone();
        public abstract void Display();
    }
}
