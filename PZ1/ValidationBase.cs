using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1
{
    public abstract class ValidationBase : BindableBase
    {
        public ValidationErrors ValidationErrors { get; set; }
        public bool IsValid { get; private set; }

        protected ValidationBase()
        {
            this.ValidationErrors = new ValidationErrors();
        }

        protected abstract void ValidateSelf();
        protected abstract void ValidateRegister();

        public void Validate()
        {
            this.ValidationErrors.Clear();
            this.ValidateSelf();
            this.IsValid = this.ValidationErrors.IsValid;
            this.RaisePropertyChanged("IsValid");
            this.RaisePropertyChanged("ValidationErrors");
        }

        public void ValidateReg()
        {
            this.ValidationErrors.Clear();
            this.ValidateRegister();
            this.IsValid = this.ValidationErrors.IsValid;
            this.RaisePropertyChanged("IsValid");
            this.RaisePropertyChanged("ValidationErrors");
        }
    }
}
