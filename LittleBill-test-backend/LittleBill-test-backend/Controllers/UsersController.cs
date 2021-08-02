using LittleBill_test_backend.Models;
using LittleBill_test_backend.Requests;
using LittleBill_test_backend.Responses;
using LittleBill_test_backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private IMailSenderService _mailSenderService;

        public UsersController(IUserService userService, IMailSenderService mailSenderService)
        {
            _userService = userService;
            _mailSenderService = mailSenderService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Nom ou mot de passe incorrect" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }


        [HttpPost("signup")]
        public IActionResult Register([FromBody] User user)
        {
            var response = _userService.Register(user);
            if (response == null)
                return BadRequest(new { message = "L'utilisateur n'a pas pu être créé" });

            return Authenticate(new AuthenticateRequest { Name = response.Name, Password = response.Password });
        }

        [HttpPost("resetPassword")]
        public void ResetPassword(ResetPasswordRequest resetPassword)
        {
            var user = _userService.GetByMail(resetPassword.mail);
            if (user != null)
                _mailSenderService.Send(user);
        }

        [HttpGet("pwTokenVerify/{token}")]
        public IActionResult VerifyTokenToAllowReset(string token)
        {
            bool result = _userService.CheckToken(token);
            if(result)
                return Ok(new ValideTokenResponse { validate=result, token=token });

            return BadRequest(new { message = "Problème lors de la vérification du token" });
        }


        [HttpPost("changePassword")]
        public IActionResult ChangePassword(ChangePasswordRequest changePassword)
        {
            if (_userService.CheckToken(changePassword.token))
            {
                _userService.ChangePassword(changePassword.mail, changePassword.password);
            }
            return Ok(new { message = "Votre mot de passe a bien été modifié" });
        }
    }
}

