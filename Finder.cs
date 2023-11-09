using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring1
{
    internal class Finder
    {
        static void Main(string[] args)
        {
            Thing t1 = new Thing { name = "John", b = DateTime.Parse("1990-01-01") };
            Thing t2 = new Thing { name = "Alice", b = DateTime.Parse("1985-01-01") };

            F f = new F { P1 = t1, P2 = t2, D = TimeSpan.FromDays(365) };

            string result = Find(f.P1, f.P2, Ft.One);
            Console.WriteLine(result);
        }

        public static string Find(Thing p1, Thing p2, Ft v)
        {
            int dd = 365;
            DateTime p1D;
            DateTime p2D;

            if (v == Ft.One)
            {
                p1D = p1.b;
                p2D = p2.b;
            }
            else
            {
                p1D = p2.b;
                p2D = p1.b;
            }

            TimeSpan a;

            if (p1D > p2D)
            {
                a = p1D - p2D;
            } 
            else 
            { 
                a = p2D - p1D;
            }

            string result;
            
            if (v == Ft.One)
            {
                if (a.Days > dd)
                    result = "G";
                else
                    result = "P";
            }
            else if (v == Ft.Two)
            {
                if (a.Days < dd)
                    result = "G";
                else
                    result = "P";
            }
            else
            {
                result = "error";
            }

            return result;
        }
    }
}
