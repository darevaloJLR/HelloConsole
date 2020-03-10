using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createMessage());
        }

        public static String createMessage()
        {
            return "Hello Console";
        }
    }
}
