using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111
{
    class numberManipulator
    {
        public int FindMax(int first, int second)
        {
            int result;
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }
    }
}
