using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPrograms
{
    internal class UpdatingBankDetails : BankDetails
    {
        public UpdatingBankDetails(int custid, long accno, string? name, string? status) : base(custid, accno, name, status)
        {
        }
        public new void WelcomeMessage()
        {
            Console.WriteLine("Overriding a constructor inside the derived class!");
        }
    }
}
