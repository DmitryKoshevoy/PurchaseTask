using System;

namespace PurchasesTask
{
    class PurchaseWithBonus : Purchase
    {
        private readonly Decimal _bonusProdPrice;
        public PurchaseWithBonus(Decimal price, DateTime date, UInt32 quantity, Decimal bonusProdPrice)
            : base(date, quantity)
        {
            _bonusProdPrice = bonusProdPrice;
            Price = PriceIs(price);
            Type = TypeOfPurchase.PurchaseWithBonus;
        }

        protected override sealed Decimal PriceIs(Decimal price)
        {
            return price - _bonusProdPrice;
        }
    }
}
