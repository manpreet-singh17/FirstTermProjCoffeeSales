using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeSalesManag_CompApp.Models
{
    public class Sale
    {
        public int ID { get; set; }

        private string _coffeeName;
        private int _Quantity;
        private double _Price;
        private double _Total;
        private string _AddBy;
        private DateTime _Date;
        private TimeSpan _Time;

        [Required]
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

        [Required]
        public int Quantity
        {
            get { return _Quantity; }
            set
            {
                Validator
                    .ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Quantity" });
                _Quantity = value;
            }
        }

        
        [Required]
        [RegularExpression(@"^[0-9]{1,5}.[0-9]{1,2}$")]
        public double Price
        {
            get { return _Price; }
            set
            {
                Validator
                .ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Price" });
                _Price = value;
            }
        }
        [Required]
        public double Total
        {
            get { return _Total; }
            set
            {
                Validator
                    .ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Total" });
                _Total = value;
            }
        }

        
        [Required]
        public string AddBy
        {
            get { return _AddBy; }
            set
            {
                Validator
                    .ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "AddBy" });
                _AddBy = value;
            }
        }

        
        [Required]
        public DateTime Date
        {
            get { return _Date; }
            set
            {
                Validator
                    .ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Date" });
                _Date = value;
            }
        }

        [Required]
        public TimeSpan Time
        {
            get { return _Time; }
            set
            {
                Validator
                    .ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Time" });
                _Time = value;
            }
        }

    }
}
