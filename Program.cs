namespace Module17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1= new Account();
            Account acc2= new Account();
            Account acc3= new Account();

            acc1.Balance = 1000;
            acc2.Balance = 50000;
            acc3.Balance = 3000;

            acc1.SetCalculateMethod(new CalculateUsualInterest());
            acc2.SetCalculateMethod(new CalculateUsualInterest());
            acc3.SetCalculateMethod(new CalculateCorpAccountInterest());

            acc1.CalculateInterest();
            acc2.CalculateInterest();
            acc3.CalculateInterest();

            Console.WriteLine(acc1.Interest);
            Console.WriteLine(acc2.Interest);
            Console.WriteLine(acc3.Interest);
        }
    }
}