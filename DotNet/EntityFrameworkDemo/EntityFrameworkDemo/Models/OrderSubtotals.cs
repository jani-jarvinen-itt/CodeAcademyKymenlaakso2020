﻿using System;
using System.Collections.Generic;

namespace EntityFrameworkDemo.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
