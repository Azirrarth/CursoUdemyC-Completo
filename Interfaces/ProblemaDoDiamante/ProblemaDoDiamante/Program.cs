using System;
using ProblemaDoDiamante.Devices;

namespace ProblemaDoDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2083 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 2083 };
            c.ProcessDoc("My Dissertation");
            c.Print("My Dissertation");
            Console.WriteLine(c.Scan());


        }
    }
}
