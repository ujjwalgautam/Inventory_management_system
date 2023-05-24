using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.net
{
    internal class totalcost
    {
        public void bill(int codes)
        {
            List<items> item = new List<items>();
            List<string> l1 = new List<string>();
            List<string> l2 = new List<string>();
            read r1 = new read();
            string file1 = @"E:\ccharp\file1.txt";
            item = r1.ReadeFromFile(file1);
            
            foreach (var i in item)
            {
                if (codes == i.code)
                {
                    l1.Add($"{i.code},{i.name},{i.price},{i.brand}");
                    string orderfille = @"E:\ccharp\orderlist.txt";
                    File.AppendAllLines(orderfille, l1);
                }
                else
                {
                    l2.Add($"{i.code},{i.name},{i.price},{i.brand}");
                    string file = @"E:\ccharp\file1.txt";
                    File.WriteAllLines(file, l2);   
                }
            }

        }
        public void displaybill()
        {
            List<items> item = new List<items>();
            read r1 = new read();
            string file1 = @"E:\ccharp\orderlist.txt";
            item = r1.ReadeFromFile(file1);
            Console.Write($"Item Name:\t");
            Console.Write($"Net Price:\t");
            Console.Write($"Tax:\t");
            Console.Write("Shipping Charge:\t");
            Console.Write($"Total cost: \n");
            float total = 0;
            foreach(var i in item)
            {
                Console.Write($"{i.name}\t\t");
                Console.Write($"{i.price}\t\t");
                Console.Write($"{i.price / 10}\t\t");
                Console.Write("50\t\t");
                Console.Write($"{ i.price + i.price / 10 + 50} \n");
                total = total+i.price + i.price / 10 + 50;
            }
            Console.Write($"Total Bill:{ total}\n\n");
            File.Delete(file1);
        }
    }
}
