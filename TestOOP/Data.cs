
namespace TestOOP
{
    public class Data
    {
       public int NumberAddTen(int num)
       {
            var counter = num;

            for (int i = 0;  i < 10; i++)
            {
                counter = counter + 1;
            }

            return counter;
       }

       public string AddAnGToMyString(string myString)
       {
            string stringToAdd = "";

            for (int i = 0; i < 5; i++)
            {
                stringToAdd += "G";
            }

            return myString + stringToAdd;
       }

       public string RemoveAnyJsPlz(string myString)
       {
            var myStringToLower = myString.ToLower();

            for (int i = 0; i < myStringToLower.Length; i++)
            {
                var character = myStringToLower.Substring(i, 1);
                if (character == "j")
                {
                    myStringToLower = myStringToLower.Remove(i, 1);
                }
            }

            return myStringToLower;
       }

        public int MultiplyByAlot(int num)
        {
            for (int i = 0; i < 4; i++)
            {
                num *= num;
            }

            return num;
        }
    }
}
