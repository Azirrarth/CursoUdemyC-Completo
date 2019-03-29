﻿using System;

namespace DataPadraoeISO8601 {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to local: "+ d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

        }
    }
}
