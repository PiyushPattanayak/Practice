using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = args[0];
            int result = 8 / 2;
            //Fully Qualified Name for the type
            Console.WriteLine(result.GetType().AssemblyQualifiedName);
            Console.WriteLine("Hello, "+ name+ "!");
            Console.ReadLine();
        }
    }
}
