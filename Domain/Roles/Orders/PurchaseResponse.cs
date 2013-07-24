﻿using System;
using LinkMe.Framework.Utility.Validation;

namespace LinkMe.Domain.Roles.Orders
{
    public class PurchaseResponse
    {
        [IsSet]
        public DateTime Time { get; set; }
        public string Message { get; set; }
    }
}