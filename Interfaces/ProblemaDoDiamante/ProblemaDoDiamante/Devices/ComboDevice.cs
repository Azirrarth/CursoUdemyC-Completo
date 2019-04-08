using System;

namespace ProblemaDoDiamante.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice Print: " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing : " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
