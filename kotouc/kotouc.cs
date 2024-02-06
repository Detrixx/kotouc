using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotouc
{
    internal class kotouc
    {
        public int hodnota {  get; private set; }
        public kotouc()
        {
             hodnota = 0;
           
        }

        public void Zatoc()
        {
            Random rnd = new Random();
            hodnota =  rnd.Next(1, 10);
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*************");
            sb.AppendLine("*           *");
            sb.AppendLine("*     "+hodnota+"     *");
            sb.AppendLine("*           *");
            sb.AppendLine("*************");
            return sb.ToString();
        }
    }
}
