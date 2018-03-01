using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Traveler
    {
        
        private string color;
        private int value;

        public string Color { get; set; }
        public int Value { get; set; }

        public Traveler()
        {
                //Default contstructor
        }

        public Traveler(string color)
        {
            this.Color = color;
           
        }

        public virtual int SwitchValue()
        {
            switch (Color)
            {
                case "blue":

                    return value = 1;
                                        
                case "green":

                    return value = 2;
                    
                    
                case "hazel":

                    return value = 3;
                                        
                case "brown":
                    
                    return value = 4;
                   
                     
                case "black":

                    return value = 5;
                                   
                default:

                    return value = 6;
                    
            }

        }   
    }
}
