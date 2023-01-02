using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Business.Abstract;
using TodoManager.Business.Helper;
using TodoManager.DataAccess.Concrete;
using TodoManager.Entities.Concrete;

namespace TodoManager.Business.Concrete
{
    public class JwtAuthenticationManager : IJwtAuthenticationService
    {
        Context context;
        private readonly IConfiguration _configuration;
        private readonly AppSettings _appSettings;

        public JwtAuthenticationManager(IOptions<AppSettings> appSettings)
        {
            context = new Context();
            _appSettings = appSettings.Value;
        }


        public User Authenticate(string username, string password)
        {
            var IsUser = context.Users.SingleOrDefault(x => x.UserName == username && x.Password == password);
            if (IsUser == null)
                return null;
            
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, IsUser.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            IsUser.Token = tokenHandler.WriteToken(token);
            //IsUser.Token = null;
            IsUser.Password = null;

            return IsUser;
        }
    }
}
