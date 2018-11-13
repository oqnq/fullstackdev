using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopAdmin.Tests.API
{
    public class EmailAPIRequest
    {
        public UserData GraphisoftUserDto { get; set; }
    }
    public class UserData
    {
        public string EmailAddress { get; set; }
    }
}
