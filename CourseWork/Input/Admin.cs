using System;

namespace CourseWork.Input
{
    [Serializable]
    public class Admin
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Admin(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
