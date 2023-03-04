using System;
using System.IO;


//namespace Sentencias
{
    class SentecniaUsing
    {
        public static void Maid(string[] args)
        {
            string s;
            using(TextWriter w = File.CreateText("LOG.TXT"))
            {
                w.writeLine("linea uno");
                w.WriteLine("linea dos");

                
            }
                using(TextReader r = File.OpenText("log.txt"))
            {
                while (( s= r.ReadLine()))!=null)
                        {
                    Console.WriteLine(s);
                }
            }
        }                

    }
}