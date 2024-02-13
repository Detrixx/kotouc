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
            int skore;
            bool toc = true;
            automat automat = new automat();
            Console.WriteLine("Vložte peníze:");
            while (!int.TryParse(Console.ReadLine(),out skore));
            automat.skore = skore;

            while (automat.skore >= 0 && toc)
            {
                
                automat.hraj();
                Console.Write(automat.ToString());
                Console.WriteLine("Ukončit stiskem N");
                if (Console.ReadLine().ToUpper()=="N")
                {
                    toc = false;
                }
            }
           
            

        }
    }
}
