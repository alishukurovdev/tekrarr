using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using ThisAndBase;

namespace ThisAndBase
{
    public class Device
    {
        public int Width {
            get
            {
                return Width;
            } set
            {
                Width = value;
            }
        }
        public int Height { get
            {
                return Height;
            }
            set { 
                Height = value;
            } 
        }
        public int Weight { get { return Weight; } set { Weight = value; } }
        protected bool IsDeviceOpen { get; set; }

        public Device()
        {
            
            IsDeviceOpen = false;
        }

        public void OpenDevice()
        {
            if (!IsDeviceOpen)
            {

                Console.WriteLine("Device opening...");
                IsDeviceOpen = true;
            }
            else
            {
                Console.WriteLine("Device already opened");
            }
        }

        public void CloseDevice()
        {
            if (!IsDeviceOpen)
            {

                Console.WriteLine("Device opening...");
                IsDeviceOpen = true;
            }
            else
            {
                Console.WriteLine("Device already opened");
            }

        }
    }
}
//Device classı var  ++
//Width, Height, Weight field-ları olur.  ++
//OpenDevice və CloseDevice voidləri var. ++
//Əgər DeviceOpen ilk dəfə və ya DeviceClose methodundan sonra işlənirsə ekrana “Device opening…” yazısını versin. 
//Əgər bir neçə dəfə ardıcıl olaraq çağırılıbsa “Device already opened” yazılsın. Qanuna uyğunluq DeviceClose voidi üçün də keçərlidir.
