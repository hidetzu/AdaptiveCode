using DuckTyping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var swan = new Swan();
            DoDuckLikeThings(swan);
            Console.ReadLine();
        }

        static void DoDuckLikeThings(dynamic duckish)
        {
            if(duckish != null)
            {
                duckish.Walk();
                duckish.Swim();
                duckish.Quack();
            }
        }
    }
}
