using book;
using book.database;
using book.enums;
using book.Helpers;
using book.meneger;
using System.Runtime.Serialization.Formatters.Binary;

namespace turbo.az
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            const string databaseFIle = "database.dat";
            AuthorManager AuthorManager = new AuthorManager();
            BookManager BookManager = new BookManager();


           

            MenyuTypes selectedMenu;

            Book Book;
            
            int id;
            l1:
            Author Author = new Author();
            ;
            Console.WriteLine("### emeliyyati secin: ");

            selectedMenu = Helper.ReadEnum<MenyuTypes>("menu: ");

            switch (selectedMenu)
            {
                case MenyuTypes.AuthorAdd:
                    Console.Clear();
                    Author.Name = Helper.ReadString("yazicinin adi: ");
                    Author.Surname = Helper.ReadString("yazicinin soyadi:  ");
                    AuthorManager.Add(Author);
                    Console.Clear();
                  

                    
                    goto l1;                    

                case MenyuTypes.AuthorEdit:
                    Console.Clear();    
                   
                    Console.WriteLine("redakte etmek isdediyinizi secin: ");

                    foreach (var item in AuthorManager)
                    {
                        Console.WriteLine(item);
                    }                  
                    id = Helper.Readint("Yazar id: ");

                    if (id == 0)
                    {
                        goto l1;
                    }
                    Author=AuthorManager.GetbyId(id);

                    if (Author == null)
                    {
                        Console.Clear();
                        goto case MenyuTypes.AuthorEdit;
                    }
                    Author.Name = Helper.ReadString("yazicinin adi: ");
                    Author.Surname = Helper.ReadString("yazicinin soyadi: ");
                    Console.Clear();
                    goto case MenyuTypes.AuthorGetAll;

                    

                   

                case MenyuTypes.AuthorRemove:
                    Console.Clear();
                    Console.WriteLine("silmek  isdediyinizi secin: ");

                    foreach (var item in AuthorManager)
                    {
                        Console.WriteLine(item);
                    }                    
                    id = Helper.Readint("Yazar id: ");
                    Author = AuthorManager.GetbyId(id);
                    if (Author == null)
                    {
                        Console.Clear();
                        goto case MenyuTypes.AuthorRemove;
                    }
                    AuthorManager.Remove(Author);
                    Console.Clear();
                    goto case MenyuTypes.AuthorGetAll;

                   


                case MenyuTypes.AuthorGetAll:
                    Console.Clear();
                    foreach (var item in AuthorManager)
                    {
                        Console.WriteLine(item);
                    }
                   
                    goto l1;
                   

                case MenyuTypes.AuthorFindbyName:
                    Console.Clear() ;
                    string name =Helper.ReadString("Yazarin adini qeyd edin ");
                    var data = AuthorManager.FindbyName(name);
                    if (data.Length == 0) 
                    {
                        Console.Clear();
                        Console.WriteLine("tapilmadi... ");
                        goto l1;
                    }
                    foreach (var item in data)
                    {
                        Console.Clear();
                        Console.WriteLine(item);
                    }
                    goto l1;

                case MenyuTypes.AuthorGetbyId:
                    Console.Clear();

                    id = Helper.Readint("Yazar id: ");

                    if (id == 0)
                    {
                        Console.Clear();
                        goto l1;
                    }
                    Author = AuthorManager.GetbyId(id);
                    if (Author == null)
                    {
                        Console.Clear();
                        Console.WriteLine("tapilmadi... ");
                        goto case MenyuTypes.AuthorGetbyId;
                    }
                    Console.Clear() ;
                    Console.WriteLine(Author);

                    goto l1;

                case MenyuTypes.BookAdd:
                    Console.Clear();    
                    Console.WriteLine("redakte etmek isdediyinizi secin: ");
                    Book = new Book();
                    foreach (var item in AuthorManager)
                    {
                        Console.WriteLine(item);
                    }
                    id = Helper.Readint("Yazar id: ");

                    Book.AuthorId = id;               
                    Book.Name = Helper.ReadString("kitabin adi: ");
                    Book.Price = Helper.readDecimall("kitab qiymeti: ");
                    Book.PageCount = Helper.Readint("kitab sehifelerinin sayi:");
                    Book.Genre = Helper.ReadEnum<GenreEnums>("kitab janri: ");

                    BookManager.Add(Book);
                    Console.Clear();                 

                    goto l1;

                    

                case MenyuTypes.BookEdit:

                    Console.Clear();
                    Console.WriteLine("Yazari secin: ");

                    foreach (var item in BookManager)
                    {
                        Console.WriteLine(item);
                    }
                    id = Helper.Readint("Yazar id: ");

                    if (id == 0)
                        goto l1;

                    Book = BookManager.GetbyId(id);

                    if (Book == null)
                    {
                        Console.Clear();
                        goto case MenyuTypes.BookEdit;
                    }
                    Book.Name = Helper.ReadString("yazicinin adi: ");
                    Book.Price = Helper.readDecimall("kitab qiymeti: ");
                    Book.PageCount = Helper.Readint("kitab sehifelerinin sayi:");
                    Book.Genre = Helper.ReadEnum<GenreEnums>("kitab janri: ");
                    Console.Clear();
                    goto case MenyuTypes.BookGetAll;

                    

                case MenyuTypes.BookRemove:
                    Console.Clear();
                    Console.WriteLine("silmek  isdediyinizi secin: ");

                    foreach (var item in BookManager)
                    {
                        Console.WriteLine(item);
                    }
                    id = Helper.Readint("Yazar id: ");
                    Book = BookManager.GetbyId(id);
                    if (Book == null)
                    {
                        Console.Clear();
                        goto case MenyuTypes.BookRemove;
                    }
                    BookManager.Remove(Book);
                    Console.Clear();
                    goto case MenyuTypes.BookGetAll;
                    

                case MenyuTypes.BookGetAll:
                    foreach (var item in BookManager)
                    {
                        Console.WriteLine(item);
                    }
                    goto l1;


                case MenyuTypes.BookFindbyName:
                    Console.Clear();
                   string bookName = Helper.ReadString("Kitabin adini qeyd edin: ");
                     var Bookdata = BookManager.FindbyName(bookName);
                    if (bookName.Length == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("tapilmadi... ");
                        goto l1;
                    }
                    foreach (var item in bookName)
                    {
                        Console.Clear();
                        Console.WriteLine(item);
                    }
                    goto l1;
                    


                case MenyuTypes.BookGetbyId:
                    Console.Clear();
                    id = Helper.Readint("Yazar id: ");

                    if (id == 0)
                    {
                        Console.Clear();
                        goto l1;
                    }
                    Book = BookManager.GetbyId(id);
                    if (Author == null)
                    {
                        Console.Clear();
                        Console.WriteLine("tapilmadi... ");
                        goto case MenyuTypes.AuthorGetbyId;
                    }
                    Console.Clear() ;
                    Console.WriteLine(Book);
                    goto l1;

                case MenyuTypes.SaveAndExit:

                  DataBase db= new DataBase();
                    db.Authors = AuthorManager;
                    db.Books = BookManager;

                    FileStream FilesStram = File.Create(databaseFIle);
                    BinaryFormatter bf= new BinaryFormatter();
                    bf.Serialize(FilesStram, db);
                    FilesStram.Flush();
                    FilesStram.Close();





                    Console.Clear();
                    Console.WriteLine("cixis ucun her hansi bir duymeni basin!");
                    Console.ReadKey();
                    break;

                default:
                    break;
            }

        }
    }
}