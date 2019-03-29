using System;
using System.Globalization;

namespace ListasFixaxao {
    class Funcionario {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem) {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString() {
            return "ID: "
                + Id
                + " , nome: "
                + Nome
                + " , Salário: "
                + Salario.ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}
