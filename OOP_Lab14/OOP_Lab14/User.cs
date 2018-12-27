using System;
namespace OOP_Lab14
{
    public class User
    {
        public string Nickname { get; set; }

        public User()
        {
            Nickname = "default";
        }

        public User(string nickname)
        {
            this.Nickname = nickname;
        }

    }
}
