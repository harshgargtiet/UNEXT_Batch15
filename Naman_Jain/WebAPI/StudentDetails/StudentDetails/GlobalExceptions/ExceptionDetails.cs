namespace StudentDetails.GlobalExceptions
{
    public class ExceptionDetails : Exception
    {
        public static List<string> exceptionMessages = new List<String> 
        {
                "Detail not found for the given rollno.",
                "User Not Found"
        };
    }
}
