using ClientesPeto.Core;
using ClientesPeto.Core.DTOs.AliadoDTOs;
using ClientesPeto.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClientesPeto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginRepository _loginrepository;
        private IConfiguration _config;

        public LoginController(LoginRepository loginRepository, IConfiguration config)
        {
            this._loginrepository = loginRepository;
            this._config = config;
        }

        [HttpPost]
        public async Task<IActionResult> Login(AliadoDto aliadodto)
        {
            var admin = await _loginrepository.GetAdmin(aliadodto);

            if (admin is null)
                return BadRequest(new { message = "Credenciales incorrectas"});

            string jwtToken = GenerateToken(admin);

            return Ok(new { token = jwtToken });
        }

        private string GenerateToken(Aliado admin)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, admin.Usuario),
                new Claim(ClaimTypes.Email, admin.ClaveEmpleado)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("JWT:Key").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds
                );

            string token = new JwtSecurityTokenHandler().WriteToken(securityToken);

            return token;
        }

    }
}
