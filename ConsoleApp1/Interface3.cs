using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Interface Inheritance
namespace ConsoleApp1
{
    //creating two classes IFlyable and IDriveable
    interface IFlyable
    {
        void Fly(); // interface method fly
    }


    interface IDriveable
    {
        void Drive(); // interface method drive
    }
    //Create a class FlyingCar that implements both IFlyable and IDriveable

    class FlyingCar: IFlyable, IDriveable
    {
        //Implement the Fly() and Drive() methods in FlyingCar.

        public void Fly()
        {
            Console.WriteLine("fly");
        }

        public void Drive()
        {
            Console.WriteLine("drive");
        }

    }
}
