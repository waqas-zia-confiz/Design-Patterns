using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory factory = new CharacterFactory();
            Random random = new Random();

            // extrinsic state
            int pointSize = 10;
            Console.WriteLine("Start of object creation "+DateTime.Now.Millisecond);
            // For each character use a new object
            for(int i =0; i< 1000000; i++)
            {
                int c = random.Next(65, 100);
                pointSize++;
                Character character = new ConcreteCharacter((char)c);
                
            }
            Console.WriteLine("End of object creation " + DateTime.Now.Millisecond);
            Console.WriteLine("Start of object creation " + DateTime.Now.Millisecond);
            // For each character use a flyweight object
            for (int i = 0; i < 1000000; i++)
            {
                int c = random.Next(65, 100);
                pointSize++;
                Character character = factory.GetCharacter((char)c);
            }
            
            Console.WriteLine("End of object creation " + DateTime.Now.Millisecond);
            // Wait for user
            Console.ReadKey();
        }
    }
}
