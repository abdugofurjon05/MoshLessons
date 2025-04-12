using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.LINQ
{


    public class Books
    {
        public string  Title { get; set; }
        public int Price { get; set; }
    }

    public class ForBooks
    {


        public static List<Books> GetBooks()
        {
            return new List<Books>()
            {
                new Books(){Title = "1984", Price=16},
                new Books(){Title = "Alchemist", Price =9},
                new Books(){Title = "Atmoic Habits", Price = 20},
                new Books(){Title = "Advance Csharp", Price = 13},
                new Books(){Title = "Csharp Indepth", Price = 25}
            };

        }

    }
}
