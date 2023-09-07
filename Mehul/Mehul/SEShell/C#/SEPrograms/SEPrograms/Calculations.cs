using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class Calculations
    {
        //Data Members
        double number1, number2;
        int ans;

        //constructor
        /*public Calculations()
        {
            this.number1 = 0.0;    
            this.number2 = 0.0;
            this.ans = 0;
        }
        */

        //parameterised constructor
        public Calculations(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.ans = 0;
        }


        //Methods
        /*  public static int Addition(double number1, double number2)
          {
             // Calculations calculations = new Calculations();

              ans = (int)(number1 + number2);
              return ans;
          }*/

        public int Addition()
        {
            //reference type = value type


            this.ans = (int)(this.number1 + this.number2);
            return this.ans;
        }
    }
}