using System;
using System.Collections.Generic;
using System.Text;

namespace ExeEHPPOO.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployers { get; set; }



        public Company(string name, double anualIncome, int numberOfEmployers) : base(name, anualIncome)
        {
            NumberOfEmployers = numberOfEmployers;
        }

        public override double Tax()
        {
            if (NumberOfEmployers > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }

        }

    }
}
