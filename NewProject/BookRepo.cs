namespace NewProject
{
    public partial class Program
    {
        public class BookRepo
        {
            public static List<Books> GetBooks()
            {
                return new List<Books>
            {
                new Books { Title = "1984", Price = 10 },
                new Books { Title = "Alchemist", Price = 20 },
                new Books { Title = "Atomic Habits", Price = 15 }
            };

            }
        }

    }
}