using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Application.ViewModels.UserView
{
    public class UserViewModel
    {
        
        public string FullName { get; private set; }
        public string Email { get; private set; }

        public UserViewModel(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }
    }
}
