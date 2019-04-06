using System;
using System.Globalization;
using System.IO;

namespace ExecicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(path);
                string sourceFolderPath = Path.GetDirectoryName(path); // pegando pasta de destino
                string targetFolderPath = sourceFolderPath + @"\out"; // cria a referencia para cirar o diretorio "\out"
                string targetFilerPath = targetFolderPath + @"\sumary.csv"; // cria a referencia para cirar o arquivo "\out"

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilerPath)) //ciando o arquivo fazendo o tratamento dos dados e sobrescrevendo os novos dados
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(','); //separa os campos onde tiver a vírgula
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);
                        //não esqueça que quando se declara um metodo na clase para fazer calculos deve conter () vazio 
                        sw.WriteLine(product.Name + " , " + product.Total().ToString("F2", CultureInfo.InvariantCulture)); //chamou o metodo Total na classe Produtct fez a soma
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
