using book.meneger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.database
{
    [Serializable]
    public class DataBase
    {
        public AuthorManager Authors { get; set; }
        public BookManager Books { get; set; }
    }
}
