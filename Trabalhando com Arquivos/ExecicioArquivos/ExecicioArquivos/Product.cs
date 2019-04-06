using System;
using System.Collections.Generic;
using System.Text;

namespace ExecicioArquivos
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total() //não esqueça que quando se declara um metodo na clase para fazer calculos deve conter () vazio 
        {
            return  Price * Quantity;
        }
    }


}
