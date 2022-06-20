using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Member:Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool IsCompany { get; set; }
        public string CompanyName { get; set; }

    }
}
