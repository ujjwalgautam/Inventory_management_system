using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.net
{
    internal class insert:items
    {
        public void InsertRecord()
        {
            Console.WriteLine("enter code");
            code = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter price");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("enter brand");
            brand = Console.ReadLine();
            write d1=new write();
            d1.WriteToFile(this.code,this.name,this.price,this.brand);
        }

    }
}
