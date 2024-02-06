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
       
            automat automat = new automat();
            automat.skore = 100;
            automat.hraj();
            Console.Write(automat.ToString());

            
        }
    }
}
