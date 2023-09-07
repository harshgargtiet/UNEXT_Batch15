namespace StudentDetails.GlobalExceptions
{
    public class ExceptionDetails : Exception
    {
        public static List<string> exceptionString = new List<string>
        {
            "No student found for given ID!",
            "User Not Found"
        };
    }
}
