using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace CoreApiJwtStudy.JwtHandling;

public class JwtGenerator
{
    public string GeneratedToken()
    {
        SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("test123test123tasasasassasasest123stte"));

        SigningCredentials credentials = new(key, SecurityAlgorithms.HmacSha256);

        JwtSecurityToken token = new(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(20), signingCredentials: credentials);

        JwtSecurityTokenHandler handler = new();

        var writeHandler = handler.WriteToken(token);

        return writeHandler;

    }

}
