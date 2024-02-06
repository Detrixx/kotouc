using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotouc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kotouc k = new kotouc();
            k.Zatoc();
            Console.Write(k.ToString());

            automat automat = new automat();
            Console.Write(automat.ToString());
            
        }
    }
}
