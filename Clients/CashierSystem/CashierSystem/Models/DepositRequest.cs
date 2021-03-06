﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CashierSystem.Models
{
    public class DepositRequest
    {
        /// <summary>
        /// DateTime stamp the deposit was made
        /// </summary>
        [Required]
        public DateTime DateRequested { get; set; }

        /// <summary>
        /// The account holders name
        /// </summary>
        [Required, Display(Name = "Account Holder Name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The bank account number
        /// </summary>
        [Required, MinLength(8), MaxLength(8)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The bank account sort code, required format "123456" (no hyphens)
        /// </summary>
        [Required, MinLength(6), MaxLength(6)]
        public string SortCode { get; set; }

        /// <summary>
        /// Total cash value of the deposit transaction
        /// </summary>
        [Required, Range(1, 10000)]
        public decimal TotalCashValue { get; set; }
    }
}