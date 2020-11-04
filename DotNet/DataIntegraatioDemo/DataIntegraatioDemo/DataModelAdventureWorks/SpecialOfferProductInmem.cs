using System;
using System.Collections.Generic;

namespace DataIntegraatioDemo.DataModelAdventureWorks
{
    public partial class SpecialOfferProductInmem
    {
        public SpecialOfferProductInmem()
        {
            SalesOrderDetailInmem = new HashSet<SalesOrderDetailInmem>();
        }

        public int SpecialOfferId { get; set; }
        public int ProductId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ProductInmem Product { get; set; }
        public virtual SpecialOfferInmem SpecialOffer { get; set; }
        public virtual ICollection<SalesOrderDetailInmem> SalesOrderDetailInmem { get; set; }
    }
}
