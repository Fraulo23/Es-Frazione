using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Frazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frazione f = new Frazione(16, 32);
            Frazione f2=Frazione.Parse(f.ToString());
            Console.WriteLine(f2);
            Console.ReadLine();
        }
    }
}
