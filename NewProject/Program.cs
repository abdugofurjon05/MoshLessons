
using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using MoshLessons;



namespace NewProject
{
    public partial class Program
    {
        public delegate void MyDelegate(string str);
 
        public static void Main(string[] args)
        {
            //delegates.
            /*
            System.Action<string> del = PrintIt;
            del("hello");
            System.Func<int,int,string> func = (a,b) =>System.String.Format("output : {0}", Resources<int>.Max(a, b));
            Console.WriteLine(func(1,2));
            */
            //Lambda Expressions with Delegates.
            /*
            var books = BookRepo.GetBooks();
            var take = books.FindAll(book => book.Price<=15);

            foreach(var book in take)
            {
                Console.WriteLine(book.Title);
            }*/


 
            Console.ReadKey();
        }
        //public static bool CheapBooks(Books book) => book.Price <= 15; 

        public static void PrintIt(string str) => Console.WriteLine(str);

    }
}