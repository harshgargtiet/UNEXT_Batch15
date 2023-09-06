using System.Security.Claims;
using System.Text;

namespace StudentDetails.Services
{
    public class TokenService : IToken
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(string username, string role)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            // var secretKey = Encoding.UTF8.GetBytes("Token Key");
            // var secretKey = Encoding.UTF8.GetBytes(_configuration["JwtSettings:Token Key"]);
            var secretKey = Encoding.ASCII.GetBytes("This Token is the JWT Token.....");

            var issuer = jwtSettings["Issuer"];
            // var audience = jwtSettings["Audience"];
            //double min = Convert.ToDouble("ExpiresIn");
            //var expires = DateTime.UtcNow.AddMinutes(min);
            //var expires = DateTime.UtcNow.AddMinutes(5); 
            // Convert.ToDouble(_configuration["JwtSettings:ExpiresIn"]));

            var claims = new[]
            {
new Claim(ClaimTypes.NameIdentifier, username),
new Claim(ClaimTypes.Role, role)
};

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                // Expires = expires,
                Issuer = issuer,
                // Audience = audience,
                SigningCredentials = new SigningCredentials(
            new SymmetricSecurityKey(secretKey),
            SecurityAlgorithms.HmacSha512Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);


        }
    }
