using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncoding
{
    public class RunLengthEncoding
    {
        public static string Encode(string input)
        {
            int count = 1;
            char prevChar = char.MinValue;
            string resStr = "";
            foreach (char curChar in input)
            {
                if (curChar != prevChar)
                {
                    if (prevChar != char.MinValue)
                    {
                        if (count > 1)
                        {
                            resStr += count;
                        }

                        resStr += prevChar;
                    }
                    count = 1;
                    prevChar = curChar;
                }
                else
                    count++;
            }
            if (count > 1)
            {
                resStr += count;
            }
            if (input != "")
            {
                resStr += prevChar;
            }
            return resStr;
        }

        public static string Decode(string input)
        {
            double count = 0;
            string resStr = "";
            foreach (char curChar in input)
            {
                if (char.IsNumber(curChar))
                {
                    count = (count * 10) + char.GetNumericValue(curChar);
                }
                else
                {
                    if (count > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            resStr += curChar;
                        }

                    }
                    else
                    {
                        resStr += curChar;
                    }
                    count = 0;
                }
            }
            return (resStr);
        }
    }
    class Program
    {
        static void Main()
        {

        }
    }
}
