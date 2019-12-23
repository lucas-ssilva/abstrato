using System;
using System.Collections.Generic;
using System.Text;

namespace abstrato.Entities
{
    class Individual : TaxPayer
    {
        public double healthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name,anualIncome)
        {
            this.healthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double taxa = 0;
            if (AnualIncome >= 20000.00)
            {
                taxa = 0.25;
            }
            else
            {
                taxa = 0.15;
            }

            return (AnualIncome * taxa) - (healthExpenditures * 0.50);
        }
    }


}
