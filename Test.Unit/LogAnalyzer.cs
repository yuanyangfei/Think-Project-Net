using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Unit
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string name)
        {
            if (name.EndsWith(".png"))
            {
                return true;
            }
            else
                return false;
        }

    }
}
