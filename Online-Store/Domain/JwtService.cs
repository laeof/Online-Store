using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Online_Store.Domain
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
                { "id", id.ToString() }, // Добавляем ID пользователя в полезную нагрузку
                { JwtRegisteredClaimNames.Exp, DateTime.Today.AddMinutes(1) } // Время истечения токена
            };

            var securityToken = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
        public bool Verify(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key_here")),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            try
            {
                var claimsPrincipal = tokenHandler.ValidateToken(jwt, tokenValidationParameters, out _);
                var idClaim = claimsPrincipal.FindFirst("id");
                if (idClaim != null && Guid.TryParse(idClaim.Value, out Guid userId))
                {
                    return true;
                }
                else
                {
                    // Invalid token or missing ID claim
                    return false; // Или выбросьте исключение в зависимости от вашей логики
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок при валидации токена
                return false; // Или выбросьте исключение в зависимости от вашей логики
            }
        }
    }
}