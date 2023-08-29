using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealdClass
{
    internal  class Vehicle

    {
        
      public void StartEngine()
        {
            Console.WriteLine("engine stated:");
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine Stooped");
        }

    }
    sealed class Car:Vehicle
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartEngine();
            car.StopEngine();
        }
    }
}
