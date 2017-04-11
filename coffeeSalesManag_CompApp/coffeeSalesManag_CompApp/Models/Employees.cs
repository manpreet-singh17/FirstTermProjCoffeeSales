using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeSalesManag_CompApp.Models
{
    public class Employees
    {
        public int ID { get; set; }

        private string _userName { get; set; }
        [Required]
        public string UserName
        {
            get { return _userName; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "UserName" });
                _userName = value;
            }
        }

        private string _password { get; set; }
        [Required]
        public string Password
        {
            get { return _password; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Password" });
                _password = value;
            }
        }

        private string _name { get; set; }
        [Required]
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Name" });
                _name = value;
            }
        }

        private int _age { get; set; }
        [Required]
        public int Age
        {
            get { return _age; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Age" });
                _age = value;
            }
        }

        private string _gender { get; set; }
        [Required]
        public string Gender
        {
            get { return _gender; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Gender" });
                _gender = value;
            }
        }

        private int _mobNumber { get; set; }
        [Required]
        public int MobileNumber
        {
            get { return _mobNumber; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "MobileNumber" });
                _mobNumber = value;
            }
        }

        private string _address { get; set; }
        [Required]
        public string Address
        {
            get { return _address; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Address" });
                _address = value;
            }
        }
        public DateTime DateTime { get; set; }

    }
}
