using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class BankDetails
    {
        private int custid;
        private long accno;
        private string? name, status;

        public BankDetails(int custid, long accno, string? name, string? status)
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

        public void GetAccountDetails(int custid)
        {
            if (Custid == custid)
            {
                Console.WriteLine(Accno + " " + Name + " " + Status);
            }
        }

        public void GetAccountDetails(long accno)
        {
            if (Accno == accno)
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
}
