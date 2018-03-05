using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitStuff
{
    public class BitStuff
    {
        public static uint BitCount(int input) //Bit Count - counts bits in a given number. Negative numbers allowed.
        {
            uint result = 0;
            uint unum = unchecked((uint)input);
            while (unum != 0)
            {
                result = result + (unum & 1);
                unum >>= 1;
            }
            return (result);
        }

        public static string ParityControl(string input) //Parity Control - decodes string of byte-sized numbers into ASCII string without numbers with uneven amount of bits. No negative numbers allowed!
        {
            string result = "", curnum = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    curnum += input[i];
                }
                else
                {
                    result += (BitCount(int.Parse(curnum)) % 2 == 0 ? Convert.ToString((char)(int.Parse(curnum) & 127)) : "");
                    curnum = "";
                }
            }
            result += (BitCount(int.Parse(curnum)) % 2 == 0 ? Convert.ToString((char)(int.Parse(curnum) & 127)) : "");
            return (result);
        }
    }

    public class Programm
    {

        static void Main(string[] args)
        {

        }
    }
}
