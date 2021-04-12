using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Class2 
    {
        public int quant, pricy;

        public int metho
        {
            set { quant = value; pricy = value;  }
            get { return quant + pricy;  }
        }


    }
}
