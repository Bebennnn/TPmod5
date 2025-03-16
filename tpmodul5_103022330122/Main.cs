using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022330122
{
    class Utama
    {
        public static void Main(string[] args)
        {
            DataGeneric<String> dataGen = new DataGeneric<string>("103022330122");
            dataGen.Print();
        }

    }
}