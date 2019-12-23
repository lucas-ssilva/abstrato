using System;
using System.Collections.Generic;
using System.Text;

namespace abstrato.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome , int numberOfEmployees) : base(name , anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxa = 0;
            if (NumberOfEmployees > 10)
            {
                taxa = 0.14;
            }
            else
            {
                taxa = 0.16;
            }
            return AnualIncome * taxa;
        }
    }
}
