using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Model
{
    public enum Type
    {
        Admin = 1,
        Reader = 0
    }
    public class User
    {
        public string username;
        public string password;
        public int id;
        public Type type;

    }
}