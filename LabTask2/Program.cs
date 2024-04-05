namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateStyle dateStyle = new EuropeanStyle();
            dateStyle = new Decorator(dateStyle);
            Console.WriteLine(dateStyle.GetInfo());

            DateStyle dateStyle2 = new Decorator(new Decorator(new AmericanStyle()));
            Console.WriteLine(dateStyle2.GetInfo());

        }
    }
}