﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {
        public int ID { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
    }
}