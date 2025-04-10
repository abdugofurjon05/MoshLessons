namespace MoshLessons
{
    public class Uknown : Car
    {
        private int _number;
        public Uknown(string registerNumber, string company, int number) : base (registerNumber, company)
        {
            _number = number;
            Console.WriteLine("this unknow class.");
        }
    }
}