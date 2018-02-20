using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Welcome!" );

            Console.Write( "Enter X for first point: " );
            float x1 = float.Parse( Console.ReadLine() );
            Console.Write( "Enter Y for first point: " );
            float y1 = float.Parse( Console.ReadLine() );

            Console.Write( "Enter X for second point: " );
            float x2 = float.Parse( Console.ReadLine() );
            Console.Write( "Enter Y for second point: " );
            float y2 = float.Parse( Console.ReadLine() );

            double dist = Math.Sqrt( Math.Pow( x2 - x1, 2 ) + Math.Pow( y2 - y1, 2 ) );
            double angle = Math.Atan2( y2 - y1, x2 - x1 ) * ( 180 / Math.PI );

            Console.WriteLine( "Distance between points: " + dist );
            Console.WriteLine( "Angle between points: " + angle + " degrees" );

            Console.ReadLine();
        }
    }
}
