using System;
using System.Globalization;

namespace Exercicio3 {
    class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Soma() {
            return Nota1 + Nota2 + Nota3;
        }

        public double Faltam() {
            return 60 - Soma() ;
        }

    }
}
