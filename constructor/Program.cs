using System;
namespace construtorFundamental
{
    class Program
    {
        static void Main()
        {
            Customer customerEmpty = new Customer();
            Customer constructor2Para = new Customer(1," Nitesh");

            customerEmpty.Displaydata();

            constructor2Para.Displaydata(true);

        }
    }
}