using System;
using System.Collections.Generic;


namespace ExeEHPPOO.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpedure { get; set; }

        public Individual(string name, double anualIncome, double healthExpedure) : base(name, anualIncome)
        {
            HealthExpedure = healthExpedure;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpedure * 0.5;

            }
            else
            {
                return AnualIncome * 0.25 - HealthExpedure * 0.5;
            }

        }

    }
}
