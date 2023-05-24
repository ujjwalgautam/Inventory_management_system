using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.net
{
    internal class order:items
    {
        public void orderitem()
        {
            totalcost t1=new totalcost();
            string con= "y";
            List<items> item = new List<items>();
            read r1=new read();
           
            while (con == "y")
            {
                string file1 = @"E:\ccharp\file1.txt";
                item = r1.ReadeFromFile(file1);
                Console.WriteLine("enter item codes to order");
                int l = int.Parse(Console.ReadLine());
                bool b = false;
                foreach(items i in item)
                {
                    if(i.code == l)
                    {
                        b = true;
                    }
                }
                if (b)
                {
                    var codes = from i in item
                                where i.code == l
                                select i.code;
                    foreach (int code in codes)
                    {
                        t1.bill(code);

                    }

                }
                else
                {
                    Console.WriteLine("item not found");
                }

                Console.WriteLine("Do you want to order more item?(y/n)");
                con = Console.ReadLine();
            }

        }
        
    }
}
