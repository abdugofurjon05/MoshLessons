namespace NewProject
{
    public partial class Program
    {
        public class Resources<T> where T : IComparable
        {
            public static T Max(T a,T b)
            {
                return a.CompareTo(b) > 0? a : b;  
            }
        }
    }
}