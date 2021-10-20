using System;
using System.ComponentModel.DataAnnotations;

namespace SOLID
{
    public class UserService
    {

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);

            SendEmail(user);
        }

        public void Login(string email, string password)
        {
            Console.WriteLine("Login");
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(User message) => Console.WriteLine("send message");


    }
    public class User
    {
        private readonly string _email;
        private readonly string _password;

        public User(string email, string password)
        {
            _email = email;
            _password = password;
        }


    }
}
