namespace Course6.Entities
{
    class Company : Account
    {
        public int NumberOfEmployee { get; set; }

        public Company()
        {

        }
        public Company(string name, double annualIncome, int numberOfEmployee)
            :base(name,annualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double Tax()
        {
            if (NumberOfEmployee > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
