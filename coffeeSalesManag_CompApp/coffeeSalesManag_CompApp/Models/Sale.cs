using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeSalesManag_CompApp.Models
{
    public class Sale
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string CoffeeName { get; set; }

        [Required]
        [MinLength(1)]
        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Required]
        [MinLength(1)]
        [DataType(DataType.Currency, ErrorMessage = "Please fill currency format.")]
        public int Price { get; set; }

        [Required]
        [MinLength(1)]
        [DataType(DataType.Currency, ErrorMessage = "Please fill currency format.")]
        public int Total { get; set; }

        [Required]
        [MinLength(1), MaxLength(100)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int MobileNumber { get; set; }

    }
}
