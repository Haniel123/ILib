using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Usert
    {
        public string Status { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string IdType { get; set; }
    }

    public class UserType
    {
        public string Username { get; set; }
        public string Status
        {
            get; set;
        }
    }
    public class Author
    {
        public string Username { get; set; }
        public string Status
        {
            get; set;

        }
    }
}
