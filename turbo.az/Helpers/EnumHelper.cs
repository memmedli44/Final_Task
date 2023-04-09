using book.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Helpers
{
    public static partial class Helper
    {
        public static T ReadEnum<T>(string captions)
            where T : Enum
        {
            var menu = Enum.GetValues(typeof(T));

            foreach (var item in menu)
            {
                Type uType= Enum.GetUnderlyingType(typeof(T));

                var id = Convert.ChangeType(item, uType);

                Console.WriteLine($"{id.ToString().PadLeft(2, '0')}. {item}");
            }
           

        l1:
            ConsoleColor OldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(captions);
            Console.ForegroundColor = OldColor;

           string income=Console.ReadLine();

            if (!Enum.TryParse(typeof(T),income, out object value) || !Enum.IsDefined(typeof(T),value))
            {
                goto l1;
            }

            return (T)value;
            
        }
    }
}
