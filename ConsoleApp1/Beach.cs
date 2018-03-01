using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class Beach: Traveler
    {
        
        public Beach()
        {
            //default constructor
        }

        public Beach(string color)
        {
            this.Color = color;
            
        }

        //public override int SwitchValue()
        //{
        //    int value = base.SwitchValue();
        //    GetBeach(value);
        //    return base.SwitchValue();
        //}

        //public static void GetBeach(int value)
        //{
         
        //    if (value == 1)
        //    {
        //        Console.WriteLine("Huntington Beach California");
        //    }
        //    else if (value == 2)
        //    {
        //        Console.WriteLine("Newport Beach California");
        //    }
        //    else if (value == 3)
        //    {
        //        Console.WriteLine("Seal Beach California");
        //    }
        //    else if (value == 4)
        //    {
        //        Console.WriteLine("Hermosa Beach California");
        //    }
        //    else if (value == 5)
        //    {
        //        Console.WriteLine("Pacific Beach California");
        //    }
        //    else if (value == 6)
        //    {
        //        Console.WriteLine("Ocean Beach California");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Imperial Beach California");
        //    }

        //}
    }
}
