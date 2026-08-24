using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{
    class Func
    {
        public bool IsNumber(string s)
        {
            bool f = false;
            for(int i=0; i<s.Length;i++)
            {
                if(s[i]=='.')
                {
                    if (f == false) f = true;
                    else
                    return false;
                }
                else if(s[i]>'9'||s[i]<'0')
                {
                    return false;
                }
                
                
            }
            
            return true;
        }

        public bool IsNumberDouble(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                {
                    return true;

                }
                
            }

            return false;
        }

    }
}
