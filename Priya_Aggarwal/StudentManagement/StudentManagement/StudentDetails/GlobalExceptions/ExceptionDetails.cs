namespace StudentDetails.GlobalExceptions
{
    public class ExceptionDetails : Exception
    {
        public static List<string> exceptionMessages = new List<string> 
        {
            "Student with the given rollno is absent",
            "User not found"
        };
    }
}
