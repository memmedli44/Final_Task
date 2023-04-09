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
            int index = Array.IndexOf(data, item);

            if (index == -1)
                return;
            
            var found = data[index];

            found.Name = item.Name;
            found.AuthorId= item.AuthorId;
            found.PageCount = item.PageCount;
            found.Price = item.Price;
            found.Genre = item.Genre;
            
        }
        public void Remove(Book item)
        {
            int index = Array.IndexOf(data, item);

            if (index == -1)
                return;

            int len = data.Length - 1;
            for (int i = index; index < len; index++)
            {
                data[i] = data[i + 1];
            }
            Array.Resize(ref data, len);
        }


        public Book this [int index]
        { 
            get 
            {
                return data[index]; 
            } 
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

        public Book GetbyId(int id)
        {
            return Array.Find(data, item => item.Id == id);
        }

        public Book[] FindbyName(string name)
        {
            return Array.FindAll(data, item => item.Name.ToLower().StartsWith(name.ToLower()));
        }
    }
}
