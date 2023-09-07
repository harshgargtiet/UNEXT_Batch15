namespace StudentDetails.GlobalExceptions
{
    public class ExceptionDetails : Exception
    {
        public static List<string> exceptionStrings = new List<string>
        {
            "No student found for given ID :("
        };
    }
}
