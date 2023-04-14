using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{

    internal class Program
    {
        static void Main(string[] args)
        {
           //NB: Both the low level and high level class depends on the abstraction ie,the interface.
            
            IAutomobile automobile = new Car();
            AutomobileController controller = new AutomobileController(automobile);
            controller.DisplayWheels();


            Console.ReadKey();
        }
    }



    //High level class
    public class AutomobileController
    {
      private  IAutomobile _automobile;
        public AutomobileController(IAutomobile automobile)
        {
            _automobile = automobile;
        }

        public void DisplayWheels()
        {
            Console.WriteLine($"{_automobile.NoOfWheels()} wheels");
        }

    }

    //High level class ends
      
    
     public interface IAutomobile
    {
        int NoOfWheels();
    }

    //Low level classes
    public class Bike : IAutomobile
    {
        public int NoOfWheels()
        {
            return 2;
        }
    }

    public class Car : IAutomobile
    {
        public int NoOfWheels()
        {
            return 4;
        }
    }
    //Low level classes ends



}
