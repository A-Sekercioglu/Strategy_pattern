using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_design_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dukkan Dukkan = new dukkan();
            sanal Sanal = new sanal();
            vahiy Vahiy = new vahiy();
            organ Organ = new organ();
            Sat sat = new Sat(Sanal);
            Console.ReadKey();
        }
        
        class gitar
        {
            public gitar(string alimyeri)
            {
                Console.WriteLine($"Gitarınız {alimyeri} alınmıştır");
            }

        }
        abstract class Strategy
        {
            public abstract gitar Al();
        }
        class dukkan : Strategy
        { 
        public override gitar Al() 
            {
                return new gitar("dükkandan"); 
            }
        }
        class sanal:Strategy
        {
            public override gitar Al()
            {
                return new gitar("internetten");
            }
        }
        class vahiy:Strategy
        {
            public override gitar Al()
            {
                return new gitar("vahiy yoluyla");
            }
        }
        class organ : Strategy
        {
            public override gitar Al()
            {
                return new gitar("organ mafyasından");
            }
        }
       class Sat
        {
            public Sat(Strategy taktik)
            {
                taktik.Al();
            }
        }
    }
}
