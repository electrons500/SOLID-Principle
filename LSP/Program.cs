using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    //NB:LSP can be implemented when the program is in OCP.LSP is an extension of OCP

    interface IMembership
    {
        int GetTraining();

    }

    public class Membership:IMembership
    { 
        public int GetTraining()
        {
            return 2;  
        }

    }

    public class PlusMembership : IMembership
    {
        public int GetTraining()
        {
            return 5;
        }
        

    }

    public class ProMembership : IMembership
    {
        public  int GetTraining()
        {
            return 10;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IMembership membership = new Membership();
            Console.WriteLine(membership.GetTraining());

            IMembership plusmembership = new PlusMembership();
            Console.WriteLine(plusmembership.GetTraining());


            Console.ReadKey();
        }

    }
}
