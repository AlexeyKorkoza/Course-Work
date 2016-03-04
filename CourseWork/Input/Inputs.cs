using System;

namespace CourseWork.Input
{
    [Serializable]
    public class Inputs
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Inputs()
        { }
 
        public Inputs(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
