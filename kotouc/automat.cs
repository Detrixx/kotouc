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
        public int skore { get; set;}

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
            sb.AppendLine("Počet skóre: "+skore);
            return sb.ToString();
        }

        private bool kontrolaVyhryBig()
        {
            if (kotoucList[0].hodnota== kotoucList[1].hodnota && kotoucList[0].hodnota == kotoucList[2].hodnota)
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
                if (kotouc.hodnota % 2 == 0)
                {
                    return false;
                }
            }
            return true;
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
            if (kontrolaVyhryBig())
            {
                skore += 100;
            }
            else if (kontrolaVyhrySmallLiche() | kontrolaVyhrySmallSude())
            {
                skore += 10;
            }
            else
            {
                skore -= 5;
            }
        }
    }
}
