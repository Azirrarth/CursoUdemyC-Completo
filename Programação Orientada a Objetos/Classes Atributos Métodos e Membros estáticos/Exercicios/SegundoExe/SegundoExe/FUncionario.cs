using System;
using System.Globalization;

namespace SegundoExe {
    class FUncionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double Liquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
             SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }
        public override string ToString() {
            return Nome 
                + ", " 
                + "$ " + Liquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
