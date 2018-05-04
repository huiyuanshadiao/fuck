using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0100
{
    class Program
    {
        static void Main(string[] args)
        {
            int xiaoming = 170;
            //小龙 = 小明
            int xiaolong = xiaoming;
            Console.WriteLine("以前小明身高{0},小龙身高{1}",xiaoming,xiaolong);
            xiaolong = 180;
            Console.WriteLine("现在小明身高{0},小龙身高{1}",xiaolong,xiaoming);
            Console.ReadLine();
        }
    }
}
