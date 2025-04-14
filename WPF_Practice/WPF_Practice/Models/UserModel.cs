using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practice.Models
{
    public class UserModel
    {
        private string _name;
        private string _lastName;
        private string _email;
        private string _password;

        public string Name 
        { 
             get => _name; 
             set 
                { 
                    if (_name != value)  _name = value; 
                } 
        
        }
        public string LastName 
        { 
            get => _lastName; 
            set 
            { 
                if(_lastName != value) _lastName = value;
            }
        
        }
        public string Email 
        {
            get => _email;
            set 
            {
                if (_email != value) _email = value; 
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value) _password = value;
            }
        }  
    }

}
