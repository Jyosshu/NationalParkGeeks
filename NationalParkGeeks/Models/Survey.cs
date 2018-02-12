using System;
using System.ComponentModel.DataAnnotations;
namespace NationalParkGeeks.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        private string EmailAddress { get; set; }

        [Required(ErrorMessage = "State is required")]
        [DataType(DataType.Text)]
        private string State { get; set; }

        [Required(ErrorMessage = "Activity Level is required")]
        private string ActivityLevel { get; set; }

        [Required(ErrorMessage = "ParkCode is required")]
        private string ParkCode { get; set; }


        public Survey()
        {
        }
    }
}
