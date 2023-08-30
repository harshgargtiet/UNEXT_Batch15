using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSECustom
{
    internal class RankDetails
    {
        private int custid;
        private long accno;
        private string? name, status;

        public RankDetails (int custid, long accno, string? name, string? status)
        {
            Custid = custid;
            Accno = accno;
            Name = name;
            Status = status;
        }

        public int Custid { get => custid; set => custid = value; }
        public long Accno { get => accno; set => accno = value; }
        public string? Name { get => name; set => name = value; }
      
        public string? Status { get => status; set => status = value; }

        public void WelcomeMessage()
        {
            Console.WriteLine("Hello...\n");
        }
        public void GetAccountDetails(int custId)
        {
            if(custId == this.custid)
            {
                Console.WriteLine(Accno + " " + Name + " " + Status);
            }

        }
        public void GetAccountDetails(string name)
        {
            if (Name.Equals(name))
            {
                Console.WriteLine(Accno + " " + Name + " " + Status);
            }

        }
    }
}
