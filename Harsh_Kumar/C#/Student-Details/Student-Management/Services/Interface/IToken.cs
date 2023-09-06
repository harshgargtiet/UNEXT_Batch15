namespace Student_Management.Services.Interface
{
    public interface IToken
    {
        string GenerateToken(string username, string role);
    }
}
