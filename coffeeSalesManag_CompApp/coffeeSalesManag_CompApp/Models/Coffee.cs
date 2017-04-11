using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace coffeeSalesManag_CompApp.Models.CoffeeManagement
{
    public class Coffee
    {
        public int ID { get; set; }

        private string _coffeeName;

        [Required]
        [RegularExpression(@"^[a-zA-Z ]{3,20}$", ErrorMessage = "Please enter a valid Coffee Name. Length should be between 3 and 20.")]
        public string CoffeeName
        {
            get { return _coffeeName; }

            set
            {
                Validator
                    .ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "CoffeeName" });
                _coffeeName = value;
            }
        }

        private string _coffeePrice;
        [Required]
        [RegularExpression("^[0-9]{1,5}.[0-9]{2}$", ErrorMessage ="Please enter a valid amount with precision of 2 digits.")]
        public string CoffePrice
        {
            get { return _coffeePrice; }
            set
            {
                Validator
                    .ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "CoffePrice" });
                _coffeePrice = value;
            }
        }

        [Required]
        public DateTime DateTimeStamp { get; set; }
    }
}
