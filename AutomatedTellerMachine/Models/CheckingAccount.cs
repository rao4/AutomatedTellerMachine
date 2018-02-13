using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {
        public int ID { get; set; }

        [Required]
        //[StringLength]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Account Number must between 6-10 digits.")]
        [Display(Name = "Account #")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name
        {
            get { return $"{FirstName} {LastName}"; }
        }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}