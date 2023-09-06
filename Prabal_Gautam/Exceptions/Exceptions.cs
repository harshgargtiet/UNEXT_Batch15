using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class MyExceptions
    {
        public static List<string> ExceptionMessages { get; } =
        new List<string>
            {
                "Account No not Valid",
                "Low Balance",
                "Amount should be greater than zero"
            };

    }
}
