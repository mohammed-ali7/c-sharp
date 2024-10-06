using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
    //Basic Interface Implementation
namespace ConsoleApp1
{
    // Create an interface IVehicle with methods Start() and Stop()
    interface IVehicle

    {
        //methods Start() and Stop()
        void start();
        void stop();
    }
    //create two classes car and Bicycle
    //Each class have its own implementation of Start() and Stop().

    class Car 
    {
        public void start() {

            Console.WriteLine("The car is start");
        }
        public void stop()
                            {

            Console.WriteLine("The car is stop");
        }
    }
    class Bicycle
    {
        public void start()
        {

            Console.WriteLine("The car is start");
        }
        public void stop()
        {

            Console.WriteLine("The car is stop");
        }
    }

}
