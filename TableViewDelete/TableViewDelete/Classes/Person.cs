using System;
using System.Collections.Generic;
using System.Text;

namespace TableViewDelete.Classes
{
    public class Person
    {
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public Person()
        {
            Login = "alex";
            Pass = "";
            Tel = "";
            Email = "";
        }
        public Person(string login, string pass)
        {
            Login = login;
            Pass = pass;
            Tel = "";
            Email = "";
        }
        public Person(string login, string pass, string tel, string email)
        {
            Login = login;
            Pass = pass;
            Tel = tel;
            Email = email;
        }

        public string getReg()
        {
            return $"Логин: {Login}, Пароль: {Pass}, Телефон: {Tel}, Email: {Email}";
        }
    }
}
