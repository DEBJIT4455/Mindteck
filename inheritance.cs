using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT
{
    public class inheritance
    {
         class old_phone
        {
            public void Display()
            {
                Console.WriteLine("Display is present");
            }
            public void Communication()
            {
                Console.WriteLine("Communication is present");
            }
            public void MusicPlayer()
            {
                Console.WriteLine("MusicPlayer is There");
            }
        }
         class smartphone : old_phone
        {
            public void Camera()
            {
                Console.WriteLine("camera is Added to the smartphone");
            }
            public void Sensor()
            {
                Console.WriteLine("Sensor is present in the  smartphone");
            }
            static void Main()
            {
                smartphone sm = new smartphone();
                Console.WriteLine("Old features are");
                sm.Display();
                sm.Communication();
                sm.MusicPlayer();
                Console.WriteLine("--------------");
                Console.WriteLine("New features are");
                sm.Camera();
                sm.Camera();
                Console.ReadLine();

            }
        }
    }
}
