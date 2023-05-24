using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.net;

namespace OnlineShopping
{
    class Shopping
    {
        static void Main(string[] args)
        {
            string file1 = @"E:\sixth sem\dipak sir notes\csharp\orderlist.txt";
            File.Delete(file1);
            string con = "y";
            while (con == "y")
            {
                Console.WriteLine("\n\n1.Insert Inventory record");
                Console.WriteLine("2.Take Order");
                Console.WriteLine("3.Bill");
                Console.WriteLine("Enter Your Choice:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        insert item1 = new insert();
                        item1.InsertRecord();
                        break;
                    case 2:
                        order o1 = new order();
                        o1.orderitem();
                        break;
                    case 3:
                        totalcost t1 = new totalcost();
                        t1.displaybill();
                        break;

                }
                Console.WriteLine("Do you want to continue?(y/n)");
                con = Console.ReadLine();

            }
            
            
        }
    } 
}