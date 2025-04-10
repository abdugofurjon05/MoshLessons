namespace ForExecise
{
    public class Costumer
    {
        public int Age { get; set; }
        public string Name { get; set; }


        public void Promote()
        {
            Console.WriteLine((TakeIt() == 0)?"name": "age");
        }


        internal protected int TakeIt()
        {
            return 0;
        }

    }
}