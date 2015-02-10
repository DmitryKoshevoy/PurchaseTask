using System;

namespace PurchasesTask
{
    class PurchaseWithDiscount : Purchase
    {
        private readonly Byte _discountValue;
        public PurchaseWithDiscount(Decimal price, DateTime date, UInt32 quantity, Byte discount)
            : base(date,quantity)
        {
            _discountValue = discount;
            Price = PriceIs(price);
            Type = TypeOfPurchase.PurchaseWithDiscount;
        }

        protected override sealed Decimal PriceIs(Decimal price)
        {
            var value = Decimal.Round(Convert.ToDecimal(price*(1 - (Decimal)_discountValue/100)));
            return value%50 == 0 ? value : value - value%50;
        }
    }
}
