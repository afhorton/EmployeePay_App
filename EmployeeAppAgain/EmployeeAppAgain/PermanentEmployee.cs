using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAppAgain
{
    public class PermanentEmployee: Employee
    {
        // more data specific to Permanent Employees
        private decimal rrspPct; 

        // constructor 

        public PermanentEmployee (string n, decimal h, decimal r, decimal rrspPct): base(n, h, r)
        {
            this.rrspPct = rrspPct; // only initialize own data
        }

        // override inherited ToString() method 
        public override string ToString()
        {
            return base.ToString() + ", " + rrspPct.ToString("p");
        }



    }
}
