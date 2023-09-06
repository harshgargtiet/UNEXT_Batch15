namespace StudentDetails.Services.Interface
{
    public interface IToken
    {
        string GenerateToken (string username, string role);
    }

}
