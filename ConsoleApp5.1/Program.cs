using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            servicerobot s1 = new servicerobot("ServiceBot", "5000mAh", "v1.0", "Cleaning");
            s1.Display();

            servicerobot s2 = (servicerobot)s1.Clone();
            s2.Servicetask = "Cooking";
            s2.Batterycapacity = "6000mAh";
            s2.Display();

            industrialrobot i1 = new industrialrobot("IndustrialBot", "10000mAh", "v2.0", "Welding");

            i1.Display();

            industrialrobot i2 = (industrialrobot)i1.Clone();
            i2.industrialtask = "Painting";
            i2.Batterycapacity = "12000mAh";
            i2.Display();

            entertainmentrobot e1 = new entertainmentrobot("EntertainmentBot", "8000mAh", "v1.5", "Dancing");
            e1.Display();
            entertainmentrobot e2 = (entertainmentrobot)e1.Clone();
            e2.EntertainmentType = "Singing";
            e2.Batterycapacity = "9000mAh";
            e2.Display();
        }
    }
}
