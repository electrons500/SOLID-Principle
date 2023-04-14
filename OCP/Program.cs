using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
   
    public class Membership
    {
       // public int MembershipType { get; set; }

        public virtual int GetTraining()
        {
            //return 2;

            //if(MembershipType == 1) //plus membership type
            //{
            //    return 5;
            //}else if(MembershipType == 2) //pro membership type
            //{
            //    return 10;
            //}else if(MembershipType == 3) //premuim membership type
            //{
            //    return 20;
            //}
            //else
            //{
            //    return 2; // regular membership as default
            //}

            return 2;
        }

    }

    public class PlusMembership:Membership
    {
        public override int GetTraining()
        {
            return 5;
        }

    }

    public class ProMembership : Membership
    {
        public override int GetTraining()
        {
            return 10;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PlusMembership plus = new PlusMembership();
            Console.WriteLine(plus.GetTraining());
        }

    }




}
