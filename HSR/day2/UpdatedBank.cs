using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSECustom
{
    internal class UpdatedBank : RankDetails
    {
        public UpdatedBank(int custid, long accno, string? name, string? status) : base(custid, accno, name, status)
        {
        }

        public new void WelcomeMessage()
        {
            Console.WriteLine("HOLA AMIGO");

        }
    }
}
