using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISigninUser
    {
        public string Login { get; set; }  
        public string Password { get; set; }
    }
}
