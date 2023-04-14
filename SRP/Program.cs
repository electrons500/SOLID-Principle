using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Membership membership = new Membership();
            membership.Add(); 
          
        }
    }

    public class Membership
    { 
        public void Add()
        {
            try
            {
                // TO DO: Save data to DB  =============== responsiblity 1
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message); // ========== responsiblity 2

                //Since this class has multiple responsibilty(1 & 2),it defiles the SR principle.Hence 
                // we have to create a new class for  Console.WriteLine(ex.Message);

                FileLogger fileLogger = new FileLogger();
                fileLogger.LogError(ex.Message);

            }
        }

    }

    public class FileLogger
    {
        public void LogError(string message)
        {
            Console.WriteLine(message);
        }
    }


}
