﻿using PZ1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1.ViewModel
{
    public class LoginViewModel : BindableBase
    {
        public MyICommand LoginCommand { get; set; }
        private LoginModel login = new LoginModel();

        public LoginViewModel()
        {
            LoginCommand = new MyICommand(OnLogin);
        }

        public LoginModel Login
        {
            get { return login; }
            set
            {
                login = value;
                RaisePropertyChanged("Login");
            }
        }

        public void OnLogin()
        {
            Login.Validate();
        }
    }
}
