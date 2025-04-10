namespace MoshLessons
{
    public class Car : Vehical
    {
        private string _company;
        public Car(string registrNumber, string company) : base(registrNumber)
        {
            _company = company;
            Console.WriteLine("This is car class.");
        }
    }
}