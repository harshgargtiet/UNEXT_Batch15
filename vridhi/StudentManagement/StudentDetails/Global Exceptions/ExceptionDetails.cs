using System.Security.Cryptography.X509Certificates;

namespace StudentDetails.Global_Exceptions
{
    public class ExceptionDetails :Exception
    {
        
            public static List<string> exceptionmessages = new List<string> {
                "Student with the given Roll no. not present",
                "User not found"
                };
       
    }
}
