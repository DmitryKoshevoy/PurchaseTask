using System;

namespace PurchasesTask
{
    class PurchaceCasual : Purchase
    {
        
        public PurchaceCasual(Decimal price, DateTime date, UInt32 quantity):base(date,quantity)
        {
            Price = PriceIs(price);
            Type = TypeOfPurchase.CasualPurchase;
        }

        protected override sealed Decimal PriceIs(Decimal price)
        {
            return price;
        }
    }
}
