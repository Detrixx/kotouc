using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotouc
{
    internal class automat
    {
        List<kotouc> kotoucList= new List<kotouc>();

        public automat()
        {
           
            for(int i = 0; i < 3; i++)
            {
                kotouc k = new kotouc();
                kotoucList.Add(k);

            }

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var kotouc in kotoucList)
            {
               sb.Append(kotouc.ToString());
            }
            return sb.ToString();
        }

        private bool kontrolaVyhryBig()
        {
            if (kotoucList[0]== kotoucList[1]&& kotoucList[0] == kotoucList[2])
            {
                return true;
            }
            return false;
        }

        private bool kontrolaVyhrySmallSude()
        {
            foreach (var kotouc in kotoucList)
            {
                if (kotouc.hodnota % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool kontrolaVyhrySmallLiche()
        {
            foreach (var kotouc in kotoucList)
            {
                if (kotouc.hodnota % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
        
        private void zatoc()
        {
           
            foreach(var kotouc in kotoucList)
            {
                kotouc.Zatoc();
            }
        }

        public void hraj()
        {
            zatoc();
        }
    }
}
