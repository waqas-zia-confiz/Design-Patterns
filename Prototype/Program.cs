using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpBookPrototype book = new CSharpBookPrototype();
            book.Title = "Csharp Development";
            book.Pages = 301;
            JavaBookPrototype javaBook = new JavaBookPrototype();
            javaBook.Title = "Java Development";
            javaBook.Pages = 423;

            CSharpBookPrototype book2 = (CSharpBookPrototype)book.Clone();
            book2.Title = "OOP in Csharp";
            book2.Pages = 411;
            JavaBookPrototype javaBook2 = (JavaBookPrototype)javaBook.Clone();
            javaBook2.Title = "OOp in Java";
            javaBook2.Pages = 500;

            book.DisplayDetails();
            Console.WriteLine();
            javaBook.DisplayDetails();
            Console.WriteLine();
            book2.DisplayDetails();
            Console.WriteLine();
            javaBook2.DisplayDetails();
            Console.WriteLine();
        }
    }
}
