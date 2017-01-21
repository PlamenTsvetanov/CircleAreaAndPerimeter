using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CircleArea
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Enter circle area:);
        var r = double.Parse(Console.ReadLine());
        Console.WriteLine("Area="+Math.PI * r * r);
        Console.WriteLine("Perimeter= "+2 * Math.PI * r);
    }
}

