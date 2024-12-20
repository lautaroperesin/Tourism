﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismServices.Enums;

namespace TourismServices.Models
{
    public class pfTransaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public PaymentConfirmationEnum PaymentConfirmation { get; set; }

        // Eliminado
        public bool IsDeleted { get; set; } = false;
    }

}
