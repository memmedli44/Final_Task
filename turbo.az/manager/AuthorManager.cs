using book.infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.meneger
{
    public class AuthorManager : IManager<Author>,IEnumerable<Author>
    {
        Author[] data=new Author[0];
        public void Add(Author item)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = item;
        }

        public void Edit(Author item)
        {
            throw new NotImplementedException();
        }

        public Author this[int index] 
        {
            get
            {
                return data[index];
            } 
        }

        public IEnumerator<Author> GetEnumerator()
        {
            foreach (Author item in data )
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
