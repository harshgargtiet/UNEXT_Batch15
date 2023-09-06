namespace Student_Management.GlobalExceptions
{
    public class ExceptionDetails : Exception
    {
        public static List<string> exceptionmessages = new List<string>
        {
            "Student with the given Roll no not present",
            "User Not Found"
        };
    }
}
