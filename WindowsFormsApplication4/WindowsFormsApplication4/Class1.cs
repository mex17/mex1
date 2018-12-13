using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;


namespace WindowsFormsApplication4
{
    class Calculator
    {
        public double ADD(int NUM1, int NUM2)
        {
            return NUM1 + NUM2;
        }
        public double SUBSTRACT(int NUM1, int NUM2)
        {
            return NUM1 - NUM2;
        }
        public double MULTIPLY(int NUM1, int NUM2)
        {
            return NUM1 * NUM2;
        }
        public double DIVIDE(int NUM1, int NUM2)
        {
            return NUM1 / NUM2;
        }
    }
}
