using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class UpdateBankDetails : BankDetails
    {
        public UpdateBankDetails(int custid, long accno, string? name, string? status) :
            base(custid, accno, name, status)
        {
        }

        // Method overriding - same signature in base and derived class
        public new void WelcomeMessage()
        {
            Console.WriteLine("Hello from UpdateBankDetails");
        }
    }
}
