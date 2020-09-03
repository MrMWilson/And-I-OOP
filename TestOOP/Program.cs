
namespace TestOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var maths = new Mathematics();

            var seven = 7;

            var resultOfSeven = maths.IsDivisibleBy7(seven);

            if(resultOfSeven == true)
            {
                System.Console.WriteLine("is divible by 7");
            }
            else
            {
                System.Console.WriteLine("isnt");
            }

            var string1 = "LOWER CASE ME";

            var stringResult = maths.LowerCaseMe(string1);

            System.Console.WriteLine(stringResult);
        }
    }
}
