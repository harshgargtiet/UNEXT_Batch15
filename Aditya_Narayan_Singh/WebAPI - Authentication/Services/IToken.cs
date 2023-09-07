namespace StudentDetails.Services
{
    public interface IToken
    {
        string GenerateToken(string username, string role);
    }
}
