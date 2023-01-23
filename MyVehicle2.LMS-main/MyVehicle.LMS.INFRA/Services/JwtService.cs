using Microsoft.IdentityModel.Tokens;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class JwtService : IJwtService
    {
        private readonly IJwtRepository jwtRepository ;
        public JwtService(IJwtRepository jwtRepository)
        {
            this.jwtRepository = jwtRepository;
        }

        public string Auth(UsernamePassword usernamePassword)
        {
            var result = jwtRepository.AddAuthentication(usernamePassword);
            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenhand = new JwtSecurityTokenHandler();
                var tokenkey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANYSTRING]");
                var tokendesdate = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, result.Username),
                        new Claim(ClaimTypes.Role, result.RoleName),
                        new Claim(ClaimTypes.Email,result.UserId.ToString()),
                        new Claim(ClaimTypes.NameIdentifier,result.Email)
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256Signature),
                };
                var token = tokenhand.CreateToken(tokendesdate);
                return tokenhand.WriteToken(token);
            }
        }
    }
}
