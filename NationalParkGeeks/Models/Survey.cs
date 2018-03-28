using System;
using System.ComponentModel.DataAnnotations;
namespace NationalParkGeeks.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "State is required")]
        [DataType(DataType.Text)]
        public string State { get; set; }

        [Required(ErrorMessage = "Activity Level is required")]
        public string ActivityLevel { get; set; }

        [Required(ErrorMessage = "ParkCode is required")]
        public string ParkCode { get; set; }


        public Survey()
        {
        }
    }
}
