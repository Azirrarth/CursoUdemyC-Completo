using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqIntroducao
{
    class Program
    {
        static void Main(string[] args)
        {
            // especivicar o datasource

            int[] numbers = new int[] { 2, 3, 4, 5};

            // definir a expressão query

            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Executar a query

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }


        }
    }
}
