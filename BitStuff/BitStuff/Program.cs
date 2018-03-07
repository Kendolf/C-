using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitStuff
{
    public class BitStuff
    {
        public static int BitCount(int input) 
            /*
             * Bit Count - counts bits in a given number. Negative numbers allowed. http://www.codeabbey.com/index/task_view/bit-count 
             */
        {
            int result = 0;
            uint unum = unchecked((uint)input);
            while (unum != 0)
            {
                result = result + (int)(unum & 1);
                unum >>= 1;
            }
            return (result);
        }

        public static byte BitCount(byte inp)
        {
            if (inp == 0xFF) return 8;
            return (byte)((((UInt64)(0x010101 * inp & 0x249249) * 0x249249) >> 21) & 0x7);
        }

        public static string ParityControl(string input)
            /*
             * Parity Control - decodes string of byte-sized numbers into ASCII string without numbers with uneven amount of bits. No negative numbers allowed!
             * http://www.codeabbey.com/index/task_view/parity-control--ru
             */
        {
            string[] newinp = input.Split(' ');
            StringBuilder outp = new StringBuilder();
            foreach (string num in newinp)
            {
                outp.Append(BitCount(int.Parse(num)) % 2 == 0 ? Convert.ToString((char)(int.Parse(num) & 127)) : "");
            }
            return (outp.ToString());
        }

    }

    public class Programm
    {

        static void Main(string[] args)
        {

        }
    }
}
