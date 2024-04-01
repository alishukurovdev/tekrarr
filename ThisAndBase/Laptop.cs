using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAndBase
{
    public class Laptop:Device
    {
        public int PortCount { get {
                return PortCount;

            } set {
                PortCount = value;            
            } 
        }

        public Laptop(int portCount)
        {
            PortCount = portCount;
        }
    }
}
//Laptop:    ++
//PortCount field-ı var.   ++