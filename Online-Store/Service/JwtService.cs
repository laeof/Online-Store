using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using NuGet.Common;

namespace Online_Store.Service
{
    public class JwtService
    {
        public JwtService()
        {

        }
        public string Generate(Guid id)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key_here"));
            var credentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(credentials);

            var payload = new JwtPayload
            {
                { "id", id.ToString() },
                { JwtRegisteredClaimNames.Exp, DateTime.Today.AddMinutes(1) }
            };

            var securityToken = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
        public bool Verify(string jwtToken)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.ReadJwtToken(jwtToken);

                if (token.Payload.TryGetValue("id", out var idClaimValue) && idClaimValue is string idString)
                {
                    if (Guid.TryParse(idString, out var id))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
        public Guid? GetUserIdFromToken(string jwtToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(jwtToken);

            if (token.Payload.TryGetValue("id", out var idClaimValue) && idClaimValue is string idString)
            {
                if (Guid.TryParse(idString, out var id))
                {
                    return id;
                }
            }

            return null;
        }
    }
}