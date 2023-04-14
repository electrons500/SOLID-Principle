using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
   public interface IPrinterTasks
    {
        void Print();
        void Scan();
    }

    public interface IFaxTasks
    {
        void Fax();   
    }

    public interface IPhotoCopy
    {
        void PhotoCopy(); 
    }

    public class HPLaserJetPrinter : IPrinterTasks,IFaxTasks
    {
        public void Fax()
        {
            Console.WriteLine("Fax Done");
        }

        public void Print()
        {
            Console.WriteLine("Print Done");
        }

        public void Scan()
        {
            Console.WriteLine("Scan Done");
        }
    }

    public class HPCopier : IPhotoCopy
    {
        public void PhotoCopy()
        {
            Console.WriteLine("Photocopy Done");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HPLaserJetPrinter hPLaserJet = new HPLaserJetPrinter();
            hPLaserJet.Print();
            hPLaserJet.Scan();
            hPLaserJet.Fax();
           

            HPCopier hPCopier = new HPCopier();
            hPCopier.PhotoCopy();

            Console.ReadKey();

        }
    }

}
