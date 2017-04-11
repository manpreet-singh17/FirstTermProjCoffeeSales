using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeSalesManag_CompApp.Models
{
    public class Customer
    {
        public int ID { get; set; }

        private string _custName;
        private string _gender;
        private int _age;
        private int _mobileNum;
        private DateTime _dateTime;

        [Required]
        public string CustomerName
        {
            get { return _custName; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "CustomerName" });
                _custName = value;
            }
        }

        
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

        
        [Required]
        public int MobileNumber
        {
            get { return _mobileNum; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "MobileNumber" });
                _mobileNum = value;
            }
        }

        
        [Required]
        public DateTime DateTime
        {
            get { return _dateTime; }
            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "DateTime" });
                _dateTime = value;
            }
        }
    }
}
