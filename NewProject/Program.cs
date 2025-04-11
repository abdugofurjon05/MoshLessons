
using System;
using System.Diagnostics.Tracing;
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



            string str = "hello today is the shittest day but I learned a lof of shits";
            str = str.PutBounder(5);
            Console.WriteLine(str);





            var video = new Video() { Title = "Video 1" };
            var encode = new  VideoEncoder();
            var mail = new MailService();


            encode.VideoEncoded += mail.onVideoEncoded;















            Console.ReadKey();
        }
        //public static bool CheapBooks(Books book) => book.Price <= 15; 

        public static void PrintIt(string str) => Console.WriteLine(str);

    }
}