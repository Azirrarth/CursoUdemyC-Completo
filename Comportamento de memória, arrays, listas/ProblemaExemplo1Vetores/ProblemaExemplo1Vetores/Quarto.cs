using System;
using System.Globalization;

namespace ProblemaExemplo1Vetores {
    class Quarto {
        public string Nome;
        public string Email;
        public int Numero;


        public override string ToString() {
            return "Nome:"
                + Nome
                + " , "
                + " E-mail: "
                + Email
                + " , Numero do Quarto: "
                + Numero;
        }



    }
}
