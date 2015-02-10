using System;

namespace PurchasesTask
{
    class PurchaseWithTransportCosts : Purchase
    {
        private readonly Decimal _transportCosts;
        public PurchaseWithTransportCosts(Decimal price, DateTime date, UInt32 quantity, Decimal transportCosts)
            : base(date, quantity)
        {
            _transportCosts = transportCosts;
            Price = PriceIs(price);
            Type = TypeOfPurchase.PurchaseWithTransportCost;
        }

        protected override sealed Decimal PriceIs(Decimal price)
        {
            return price - _transportCosts;
        }
    }
}
