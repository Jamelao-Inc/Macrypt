using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.IO;


namespace API
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(_);

            /*
            string command = "";
            foreach(string x in args)
            {
                
                {

                }
                command += x + " ";
            }*/
            while (true)
            {
                Console.WriteLine("TYPE: ");
                cmd(Console.ReadLine());
            } 
        }
        static void cmd(string c)
        {
            if (c.Length > 0)
            {
                if (c=="e")
                {
                    Console.WriteLine("ENCRYPT ?");
                    string toEncrypt = Console.ReadLine();
                    string key = Console.ReadLine();
                    encrypt(toEncrypt, key);
                }
            }
        }

        static void encrypt(string str, string mn)
        {
            string m1 = "a2bh771k033a";
            string m2 = "tr detyi9erhydtiurhyeiu9thy48etby5957373";
            string m3 = "gesi y59yzoi98@#$G&HH5";
            string m4 = "aM64";
            string m5 = "•gr6546456";

            string key;

            if (mn == "m1")
            {
                key = m1;
            }else if (mn == "m2")
            {
                key = m2;
            }else if (mn == "m3")
            {
                key = m3;
            }else if (mn == "m4")
            {
                key = m4;
            }else if (mn == "m5")
            {
                key = m5;
            }
            else
            {
                key = mn;
            }
            Console.WriteLine(replaceStr(str, key));
            
        }

        private static string replaceStr(string c, string key)
        {
            string x = "";

            for(int i=0; i < key.Length; i++)
            {
                x += key[i]*870;
                for (int y = 0; y < c.Length; y++)
                {
                    x += c[y];

                    x = x.Replace(c[y],c[y%125]);
                    x = x.Replace(c[y], c[y % 125]);
                    x = x.Replace(c[y], c[y % 125]);
                    x = x.Replace(c[y], Convert.ToChar( new Random().Next(0,256)));
                }

            }

            return x;
        }


    }
}
