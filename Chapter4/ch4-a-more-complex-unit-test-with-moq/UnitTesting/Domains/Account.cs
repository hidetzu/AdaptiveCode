namespace Domains
{
    public class Account
    {
        public virtual void AddTransaction(decimal amount)
        {
            Balance += amount;
        }

        public decimal Balance
        {
            private set;
            get;
        }
    }
}
