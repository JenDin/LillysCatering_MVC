using System;
using System.ComponentModel.DataAnnotations;

namespace LillysCatering.Models
{
	public class Booking
	{
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "* Please enter your full name")]
        public string? Name { get; set; }

        [Display(Name = "PhoneNo")]
        [Required(ErrorMessage = "* Please enter a phone number")]
        [Phone]
        public string? PhoneNo { get; set; }

        [Display(Name = "Order")]
        [Required(ErrorMessage = "* Please enter a menu name and guest amount")]
        public string? Order { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "* Please enter an address")]
        public string? Address { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "* Please enter a delivery date")]
        [DateAttribute(ErrorMessage = "This is an invalid date. Try again!")]
        public DateTime Date { get; set; }
    }
}