using System;

namespace StringsEspeciais {
    class Program {
        static void Main(string[] args) {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            Console.WriteLine("Original: - " + original + "-");
            Console.WriteLine("To Uper: '" + s1 + "-");
            Console.WriteLine("Original: - " + original + "-");
            Console.WriteLine("To Lower: '" + s2 + "-");
            Console.WriteLine("Original: - " + original + "-");
            Console.WriteLine("Trim: '" + s3 + "-");
            Console.WriteLine("Index of 'bc' - " + n1);
            Console.WriteLine("Last Index of 'bc' - " + n2);
            Console.WriteLine("SubString na posição 3 - " + s4);
            Console.WriteLine("SubString (3, 5) - " + s5);
        }
    }
}
