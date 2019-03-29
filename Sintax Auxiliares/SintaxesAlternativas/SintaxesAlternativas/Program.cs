using System;

namespace SintaxesAlternativas {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x) {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tursday";
                    break;
                case 4:
                    day = "Wedsniday";
                    break;
                case 5:
                    day = "Thuesday";
                    break;
                case 6:
                    day = "fRIDAY";
                    break;
                case 7:
                    day = "Saturday";
                    break;

                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day);
        }

    }
}