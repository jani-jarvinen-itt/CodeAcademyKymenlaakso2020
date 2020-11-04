﻿using System;
using System.Collections.Generic;

namespace DataIntegraatioDemo.DataModelAdventureWorks
{
    public partial class SalesOrderDetailOndisk
    {
        public int SalesOrderId { get; set; }
        public long SalesOrderDetailId { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public short OrderQty { get; set; }
        public int ProductId { get; set; }
        public int SpecialOfferId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscount { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeaderOndisk SalesOrder { get; set; }
        public virtual SpecialOfferProductOndisk SpecialOfferProductOndisk { get; set; }
    }
}
