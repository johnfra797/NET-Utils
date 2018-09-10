using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Auto_Mapper;
using Utils.Auto_Fac;
using Utils.Unity_;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            //autoMapper autoMap = new autoMapper();

            autoFac autoFa = new autoFac();
            unity unitty = new unity();
            Console.ReadKey();
        }
    }
}
