
namespace TestOOP
{
    public class Mathematics
    {
        public bool IsDivisibleBy7(int num)
        {
            if (num % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        public string LowerCaseMe(string testString)
        {


            return testString.ToLower();
        }
    }
}
