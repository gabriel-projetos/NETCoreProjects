using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Models
{
    public class SigninUser : ISigninUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
