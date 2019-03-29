using System;
using System.Collections.Generic;

namespace Listas {
    class Program {
        static void Main(string[] args) {

            List<string> lista = new List<string>();
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Jose");
            lista.Add("Antonio");
            lista.Add("MArcos");
            lista.Add("Final");
            lista.Insert(6, "juose");

            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }


            Console.WriteLine("__________________________");
            Console.WriteLine("List Count: " + lista.Count);
            Console.WriteLine("__________________________");

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro A a ser encontrado é o " + s1);
            Console.WriteLine("___________________________");
            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultumo A a ser encontrado é o " + s2);
            Console.WriteLine("___________________________");

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição começanndo com a: " + pos1);
            Console.WriteLine("___________________________");

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição começanndo com a: " + pos2);
            Console.WriteLine("___________________________");

            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            foreach (string obj2 in lista2) {
                Console.WriteLine(obj2);
            }

            Console.WriteLine("___________________________");

            lista.RemoveRange(2, 2);
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            //lista.RemoveAt(6);
            //foreach (string obj in lista) {
            //    Console.WriteLine(obj);
            //}

            //lista.Remove("Alex");
            //foreach (string obj in lista) {
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine("___________________________");

            //lista.RemoveAll(x => x[0] == 'M');
            //foreach (string obj in lista) {
            //    Console.WriteLine(obj);
            //}
            //Console.WriteLine("___________________________");




        }



    }
}

