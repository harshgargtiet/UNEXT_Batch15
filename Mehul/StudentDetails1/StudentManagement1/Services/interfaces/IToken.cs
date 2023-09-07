namespace StudentManagement1.Services.interfaces
{
    public interface IToken
    {
        string GenerateToken(string username, string role);
    }
}
