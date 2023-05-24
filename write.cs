using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.net
{
    internal class write:items
    {
        public void WriteToFile(int code,string name,float price,string brand)
        {
            List<items> item = new List<items>();
            item.Add(new items { code = code, name = name, price = price, brand = brand });
            List<string> l1 = new List<string>();
            foreach (var i in item)
            {
                l1.Add($"{i.code},{i.name},{i.price},{i.brand}");
            }
            string file1 = @"E:\ccharp\file1.txt";
            File.AppendAllLines(file1, l1);

        }
    }
}
