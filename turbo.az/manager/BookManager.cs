using book.infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.meneger
{
    public class BookManager : IManager<Book>,IEnumerable<Book>

    {
        Book[] data=new Book[0];
        public void Add(Book item)
        {
            int len = data.Length;  
            Array.Resize(ref data, len+1);
            data[len] = item;
        }

        public void Edit(Book item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book item in data)
            {
                yield return item;
            }
           
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
