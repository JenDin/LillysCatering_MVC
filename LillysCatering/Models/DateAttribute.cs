using System;
using System.ComponentModel.DataAnnotations;

namespace LillysCatering.Models
{
	public class DateAttribute : ValidationAttribute
	{
        public override bool IsValid(object value)
        {
            DateTime date = Convert.ToDateTime(value);
            return date >= DateTime.Now; // Dates that are greater than or equal to today are valid
        }
    }
}

