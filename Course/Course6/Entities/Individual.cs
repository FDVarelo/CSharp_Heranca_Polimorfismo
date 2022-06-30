namespace Course6.Entities
{
    class Individual : Account
    {
        public double HealthExpenses { get; set; }

        public Individual()
        {

        }
        public Individual(string name, double annualIncome, double healthExpenses)
            :base(name,annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000.0)
            {
                return (AnnualIncome * 0.15) - (HealthExpenses * 0.50);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenses * 0.50);
            }
        }
    }
}
