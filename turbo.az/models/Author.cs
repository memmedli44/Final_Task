using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class Author
    {
        static int counter = 0;
        public Author()
        {
            counter++;
            this.Id = counter;  
        }
        public string Name { get; set; }  
        public string Surname { get; set; }
        public int Id { get;private set; }

        public override string ToString()
        {
            return $"{Id} | {Name} {Surname}";
        }
    }
}
