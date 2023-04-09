using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace book.Helpers
{
    public static partial class Helper
    {
        public static string ReadString(string captions, bool allowIsNullOrEpmty=false)
        {
            string income;

        l1:
            ConsoleColor OldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(captions);
            Console.ForegroundColor = OldColor;

            income = Console.ReadLine();
            if(allowIsNullOrEpmty==false && string.IsNullOrWhiteSpace(income))
            {
                goto l1;
            }

            return income;
        }
        public static int Readint(string captions, int min=0,int max=0)
        {
            string income;

        l1:
            ConsoleColor OldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if(min==max && max == 0)
            {
                Console.Write(captions);
            }
            else
            {
                Console.Write($"{captions},[{min} {max}]");
            }
            
            Console.ForegroundColor = OldColor;

            income = Console.ReadLine();
            if(!int.TryParse(income,out int value) || ((min!=0 || max!=0 )&&(value < min || value > max)))
            {
                goto l1;
            }

            return value;


            
        }
        public static decimal readDecimall(string captions, decimal min=0,decimal max=0)
        {
            string income;

        l1:
            ConsoleColor OldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (min == max && max == 0)
            {
                Console.Write(captions);
            }
            else
            {
                Console.Write($"{captions},[{min} {max}]");
            }
            Console.ForegroundColor = OldColor;

            income = Console.ReadLine();
            if (!decimal.TryParse(income, out decimal value) || ((min != 0 || max != 0) && (value < min || value > max)))
            {
                goto l1;
            }

            return value;

        }
    }
}
