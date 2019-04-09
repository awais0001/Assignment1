using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<Customer> customers = new List<Customer>
        {
            new Customer = { First = "Tabii", Last = "baig" },
            new Customer = { First = "Murad", Last = "Ahmad" }
        };

        

        static void Main(string[] args)
        {
            IEnumerable<Customer> Q =
                from Cust in customers
                select Cust;
            foreach (Customer c in query)
            {
                
            }
        }
    }
}
