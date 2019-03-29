using System;
using System;

namespace ExercicioEstatico4 {
    class ConversorDeMoeda {

        public static double IOF = 6.0;

        public static double DolarParaReal(double Quantia, double Cotacao ) {
            double total = Quantia * Cotacao;
            return total + total * IOF / 100.0;
        }


    }

}
