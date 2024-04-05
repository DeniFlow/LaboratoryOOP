

namespace LaboratoryOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers ratNumber = new RationalNumbers(2, 3);
            RationalNumbers ratNumber2 = new RationalNumbers(5, 6);
            Console.WriteLine(ratNumber == ratNumber2);
        }
    }
}