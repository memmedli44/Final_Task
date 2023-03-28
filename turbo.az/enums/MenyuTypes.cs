using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.enums
{
    public enum MenyuTypes:byte
    {
        AuthorAdd,
        AuthorEdit,
        AuthorRemove,
        AuthorGetAll,
        AuthorFindbyName,
        AuthorGetbyId,

        BookAdd,
        BookEdit,
        BookRemove,
        BookGetAll,
        BookFindbyName,
        BookGetbyId,
    }
}
