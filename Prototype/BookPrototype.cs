using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class BookPrototype
    {
        public string Title{
            get; set;
            }
        public string Topic
        {
            get; set;
        }
        public int Pages
        {
            get; set;
        }

        public void DisplayDetails() {
            Console.WriteLine("Book Details: ");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Topic: " + Topic);
            Console.WriteLine("Pages: " + Pages);
        }
        public abstract BookPrototype Clone();
    }
}
