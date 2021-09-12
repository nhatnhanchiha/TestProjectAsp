using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Test.WebApi.Entity
{
    public class CustomClaims
    {
        public int UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Roles { get; set; }
        public long BufferTime { get; set; }
        public long Exp { get; set; }
        public string Iss { get; set; }
        public long Nbf { get; set; }

        public static CustomClaims FromJwtSecurityToken(JwtSecurityToken token)
        {
            var claims = token.Claims.ToList();

            return new CustomClaims
            {
                UserId = int.Parse(claims.First(c => c.Type == "id").Value),
                Roles = claims.First(c => c.Type == "roles").Value,
                Exp = long.Parse(claims.First(c => c.Type == "exp").Value),
                Iss = claims.First(c => c.Type == "iss").Value,
                Nbf = long.Parse(claims.First(c => c.Type == "nbf").Value)
            };
        }
    }
}