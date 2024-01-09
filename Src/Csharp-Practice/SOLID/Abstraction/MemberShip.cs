using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Abstraction
{
    public class MemberShip
    {
        private readonly IEmailSender _emailSender;
        public MemberShip(IEmailSender emailSender) 
        {
            _emailSender = emailSender;
        }
        public void CreateUser(string email)
        {
            _emailSender.SendEmail(email);
        }
    }
}
