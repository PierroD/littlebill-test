using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using LittleBill_test_backend.Models;
using LittleBill_test_backend.Helpers;
using LittleBill_test_backend.Responses;
using LittleBill_test_backend.Requests;

namespace LittleBill_test_backend.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User GetByMail(string mail);
        User Register(User user);
        bool CheckToken(string token);
        void ChangePassword(string mail, string password);
    }

    public class UserService : ContextHelper, IUserService
    {
        private List<User> _users;
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _users = ContextHelper.context.Users.ToList();

        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _users.SingleOrDefault(x => x.Name == model.Name && x.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = TokenHelper.generateJwtToken(user, _appSettings.Secret);

            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        public User Register(User user)
        {
            if (!UserExist(user))
            {
                user.Id = _users.LastOrDefault().Id + 1;
                ContextHelper.context.Users.Add(user);
                ContextHelper.context.SaveChanges();
                _users = ContextHelper.context.Users.ToList();
                return user;
            }
            return null;
        }

        public User GetByMail(string mail)
        {
            foreach (var user in _users)
            {
                if (user.Email.Equals(mail))
                    return user;
            }
            return null;
        }

        public bool CheckToken(string token)
        {
            return TokenHelper.checkToken(this, token, _appSettings.ResetMailSecret);
        }

        public void ChangePassword(string mail, string password)
        {
            var user = _users.First(u => u.Email.Equals(mail));
            if (user != null)
            {
                user.Password = password;
                ContextHelper.context.Update(user);
                ContextHelper.context.SaveChanges();
            }
        }

        private bool UserExist(User user)
        {
            foreach (var u in _users)
            {
                if (u.Name == user.Name)
                    return true;
            }
            return false;
        }


    }

}