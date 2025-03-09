using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] quotes =
                    {
            "Believe you can and you're halfway there. –Theodore Roosevelt",
            "Success is not final, failure is not fatal: it is the courage to continue that counts. –Winston Churchill",
            "Don't watch the clock; do what it does. Keep going. –Sam Levenson",
            "Act as if what you do makes a difference. It does. –William James",
            "The only way to do great work is to love what you do. –Steve Jobs",
            "It does not matter how slowly you go as long as you do not stop. –Confucius",
            "Dream big and dare to fail. –Norman Vaughan",
            "Your limitation—it’s only your imagination."
        };

            Random random = new Random();
            int index = random.Next(quotes.Length);

            Console.WriteLine("===== Random Quote Generator =====");
            Console.WriteLine($"Today's Quote: {quotes[index]}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    }

