using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.net
{
    internal class read : items
    {
        List<items>item=new List<items>();
        public List<items> ReadeFromFile(string file1){
            if(File.Exists(file1))
            {
                List<string> l1 = File.ReadAllLines(file1).ToList();
                foreach (string l in l1)
                {
                    string[] datas = l.Split(',');
                    code = int.Parse(datas[0]);
                    name = datas[1];
                    price = int.Parse(datas[2]);
                    brand = datas[3];
                    item.Add(new items { code = code, name = name, price = price, brand = brand });
                }
                return item;

            }
            else
            {
                Console.WriteLine("No Data!!");
                return null;
            }
                

        }
            
        
    }
}
