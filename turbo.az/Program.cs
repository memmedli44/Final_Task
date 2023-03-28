using book;
using book.meneger;

namespace turbo.az
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthorManager authorManager = new AuthorManager();  

            Author author=new Author();
            author.Name = "ferhad";
            author.Surname = "babayev";
            authorManager.Add(author);
            
            Author author1=new Author();
            author1.Name = "ferhad";
            author1.Surname = "babayev";
            authorManager.Add(author1);

            Console.WriteLine(author);


            foreach (var item in authorManager)
            {
                Console.WriteLine(item);
            }

        }
    }
}