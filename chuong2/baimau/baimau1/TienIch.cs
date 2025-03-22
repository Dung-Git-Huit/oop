using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baimau
{
    public static class TienIch
    {
        public static int TimUCLN(int a, int b)
        {
            if(a == 0 || b == 0)
                return a+b;
            a=Math.Abs(a);
            b=Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                {
                    a=a-b;
                }
                else
                {
                    b=b-a;
                }
            }
            return a;
        }
    }
}
