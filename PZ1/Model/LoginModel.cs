using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1.Model
{
    public class LoginModel : ValidationBase
    {
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set
            {
                if(username != value)
                {
                    username = value;
                    RaisePropertyChanged("Username");
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if(password != value)
                {
                    password = value;
                    RaisePropertyChanged("Password");
                }
            }
        }

        protected override void ValidateSelf()
        {
            if (string.IsNullOrWhiteSpace(this.username))
            {
                this.ValidationErrors["Username"] = "Username is required.";
            }
            else if (username[0] >= '0' && username[0] <= '9')
            {
                this.ValidationErrors["Username"] = "Username can't start with a num!";
            }

            if (string.IsNullOrWhiteSpace(this.password))
            {
                this.ValidationErrors["Password"] = "Password is required!";
            }
            else if (this.password.Length <= 6)
            {
                this.ValidationErrors["Password"] = "Password length: 7 or more chars!";
            }
        }

        protected override void ValidateRegister()
        {
            if (string.IsNullOrWhiteSpace(this.username))
            {
                this.ValidationErrors["Username"] = "Username is required.";
            }
            else if (username[0] >= '0' && username[0] <= '9')
            {
                this.ValidationErrors["Username"] = "Username can't start with a num!";
            }

            if (string.IsNullOrWhiteSpace(this.password))
            {
                this.ValidationErrors["Password"] = "Password is required.";
            }
            else if (this.password.Length <= 6)
            {
                this.ValidationErrors["Password"] = "Password length: 7 or more chars!";
            }
        }
    }
}
