using book.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    [Serializable]
    public class Book : IEquatable<Book>
    {
        static int counter = 0;
        public Book()
        {
            counter++;
            this.Id= counter;
        }

        public Book(int id)
        {
            this.Id= id;
        }

        public int Id { get; private set; }
        public string Name { get; set; }   
        public int AuthorId { get; set; } 
        public int  PageCount { get; set; }
        public decimal Price { get; set; }
        public GenreEnums Genre { get; set; }

        public bool Equals(Book? other)
        {
            return other?.Id == this.Id;
        }

        public override string ToString()
        {
            return $"ID: {Id} \n Yazar ID:{AuthorId} \n Kitab adi: {Name} \n Sehife sayi: {PageCount} \n Qiymet: {Price}";
        }
    }
}
