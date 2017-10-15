using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack[] stacks = {new Stack("array"), new Stack("list"),
                new StackFIFO(), new StackHanoi()};
            for (int i = 1; i < 15; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    stacks[j].Push(i);
                }
            }
            Random rn = new Random();
            for (int i = 1; i < 15; i++)
            {
                stacks[3].Push(rn.Next(20));
            }
            for (int i = 0; i < stacks.Length; i++)
            {
                while (!stacks[i].IsEmpty())
                {
                    Console.Write(stacks[i].Pop() + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("total rejected is " + ((StackHanoi)stacks[3]).ReportRejected());
        }
    }
}
