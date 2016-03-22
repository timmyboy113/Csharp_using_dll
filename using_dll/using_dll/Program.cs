using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib;

namespace using_dll
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( lib.Test.echo("Ich bin ein Text der gleich ausgegeben wird :)"));
            Console.WriteLine(lib.Test.add(13, 37));
            Console.ReadLine();
        }
    }
}
