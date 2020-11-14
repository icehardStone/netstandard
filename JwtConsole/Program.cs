using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;

namespace JwtConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //string result = JwtString("aasssssssssssssssss", new User() { Id = "aasasasaa", Name = "admas", Roles = new List<string>() { "nurse" } });

            //Console.WriteLine(result);
            //ReadJwt(result, "aassssssssssssssss");
            Person p = new Person();
            p.Name = "this is a nam more 5";
        }
        public static string JwtString(string key, User user)
        {
            JwtHeader header = new JwtHeader(
                    new SigningCredentials(
                        new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(key)),
                        SecurityAlgorithms.HmacSha256
                        )
            );

            JwtPayload payload = new JwtPayload(
                issuer: "JwtIssuer",
                audience: "JwtAudience",
                notBefore:null,
                expires: DateTime.Now.AddDays(1),
                issuedAt:DateTime.Now,
                claims: new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,user.Name),
                    new Claim(ClaimTypes.PrimarySid,user.Id),
                    new Claim(ClaimTypes.Role,user.Roles[0])
                }
             );

            JwtSecurityToken token = new JwtSecurityToken(header, payload);
            JwtSecurityTokenHandler hander = new JwtSecurityTokenHandler();

            var jwtString = hander.WriteToken(token);
            return jwtString;
        }
        public static void ReadJwt(string jwt, string key)
        {
            JwtSecurityTokenHandler hander = new JwtSecurityTokenHandler();
            
            var result = hander.ReadJwtToken(jwt);
            TokenValidationParameters tokenValidationParams = new TokenValidationParameters()
            {
                //ValidateIssuer = true,
                //ValidateLifetime = true,
                //ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "JwtIssuer",
                ValidAudience = "JwtAudience",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
            };
            //var jwtTokenHandler = new JwtSecurityTokenHandler();
            var a = hander.ValidateToken(jwt, tokenValidationParams, out SecurityToken validated);
        }
    }
    class User
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 角色
        /// </summary>
        public List<string> Roles { set; get; }
    }
    class Person
    {
        [MaxLength(5,ErrorMessage ="名称长度不能大于5",ErrorMessageResourceType = typeof(Person))]
        public string Name { set; get; }
    }
}
