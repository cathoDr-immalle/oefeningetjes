using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string sterrentjes ="";

            //    for(int i=0; i <= 100; i++)
            //    {
            //        sterrentjes += "*" ;
            //    }

            //    Console.WriteLine(sterrentjes);

            TekenSterretjes(100);
            string sterretjes1 = MaakSterretjes(300);
        }

        

        static void TekenSterretjes(int count)
        {
            Console.Write(new string('*', count));
        }

        static string MaakSterretjes(int count)
        {
            return "";
        }

    }
}
