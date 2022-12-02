using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace adcd
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Products p1 = new Products();
            //Console.WriteLine("enter the id name price discount ");
            //int cid = Convert.ToInt32(Console.ReadLine());
            //string name = Console.ReadLine();
            //int prices = Convert.ToInt32(Console.ReadLine());
            //int discount = Convert.ToInt32(Console.ReadLine());
            //p1.ShowUse(cid, name, prices, discount);
            //p1.Calculate();
            //Console.WriteLine(p1.Print());



            Emp e1 = new Emp();
            e1.GetValues(1, "Rhual", 11000);
            e1.Salary();
            Console.WriteLine(e1.Print());

        }
    }
}
