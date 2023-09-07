namespace StudentDetails.Services.Interface
{
    public interface iToken
    {
        string GenerateToken(string username, string role);
    }
}
