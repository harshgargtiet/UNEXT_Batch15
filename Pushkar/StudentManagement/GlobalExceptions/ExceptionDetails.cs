namespace StudentDetails.GlobalExceptions
{
    public class ExceptionDetails : Exception
    {
        public static List<string> exceptionmessages = new List<string>
        { 
            "Student with the given roll no not found"
        };
    }
}
