using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class Book
    {
        static int counter = 0;
        public Book()
        {
            counter++;
            this.Id= counter;
        }
        public int Id { get; private set; }
        public string Name { get; set; }   
        public int AuthorId { get; set; } 
        public int  PageCount { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name} | {AuthorId} | {PageCount} | {Price}";
        }
    }
}
