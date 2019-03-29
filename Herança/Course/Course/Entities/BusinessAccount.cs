namespace Course.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }



        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance, double loanLimite) : base(number, holder, balance)
        {
            LoanLimit = loanLimite;
        }

        public void Loan(double ammount)
        {
            if (ammount <= LoanLimit)
            {
                Balance += ammount;
            }
        }
    }
}
