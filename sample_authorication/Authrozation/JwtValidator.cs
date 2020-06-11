using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace sample_authorication.Authrozation
{
    public class JwtValidator
    {
        /// <summary>
        /// 产生jwt
        /// </summary>
        /// <param name="key"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string ProduceJwt(string key, User user)
        {
            JwtHeader header = new JwtHeader(
                new SigningCredentials(
                    new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(key)),
                    SecurityAlgorithms.HmacSha256
                    )
                );
            JwtPayload payload = new JwtPayload(
                issuer: "JwtValidator",
                audience: "JwtAudience",
                notBefore: null,
                expires: DateTime.Now.AddSeconds(1),
                issuedAt: DateTime.Now,
               claims: new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Role,user.RoleName),
                    new Claim(ClaimTypes.PrimarySid,user.Id),
                    new Claim("RoleId",user.RoleId),
                }
             );
            JwtSecurityToken token = new JwtSecurityToken(header, payload);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            var jwtString = handler.WriteToken(token);

            return jwtString;
        }
        public static User ValidateJwt(string key, string jwtString)
        {
            TokenValidationParameters tokenValidationParams = new TokenValidationParameters()
            {
                //ValidateIssuer = true,
                //ValidateLifetime = true,
                //ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "JwtValidator",
                ValidAudience = "JwtAudience",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
            };
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var a = jwtTokenHandler.ValidateToken(jwtString, tokenValidationParams, out SecurityToken validated);
            return null;
        }
    }
}
