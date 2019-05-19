﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsuranceApp.Models
{
    public class Quote
    {
        [Key]
        public int QuoteId { get; set; }
        public string FirstName { get; set; }
	    public string LastName { get; set; }
	    public string EmailAddress { get; set; }
	    public string DateOfBirth { get; set; }
        public int CarYear { get; set; }
	    public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUI { get; set; }
        public int SpeedingTicket { get; set; }
	    public string Coverage { get; set; }
        public double Amount { get; set; }
    }
}