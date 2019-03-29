using System;
using System.Globalization;

namespace EXEPOO1 {
    class ContaBancaria {

        public string TitularDaConta { get; set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }


        public ContaBancaria(string titularDaConta, int numeroDaConta) {
            TitularDaConta = titularDaConta;
            Conta = numeroDaConta;
        }
        public ContaBancaria(string titularDaConta, int numeroDaConta, double saldo) : this(titularDaConta, numeroDaConta) {
            ValorDepositado(saldo);

        }

        public void ValorDepositado(double valor) {
            Saldo += valor;
        }
        public void ValorDeSaque(double valor) {
            Saldo -= valor + 5.00;
        }



        public override string ToString() {
            return "Numero da conta: "
                + Conta
                + " , Titular da Conta: "
                + TitularDaConta
                + " , Deposito Inicial: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}



