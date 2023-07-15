using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erafn_fixer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("OPENSSL_ia32cap", "~0x20000000");
            Console.WriteLine("Enviorment variable OPENSSL_ia32cap has been set to ~0x20000000. Please note that you have to restart PC in order to update the Enviorment Variables. Press any key to exit.");

            Console.ReadKey();
        }
    }
}
