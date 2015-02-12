using System;

namespace PurchasesTask
{
    /// <summary>
    /// Purchase with transopr costs class inherits abstract purchase class
    /// </summary>
    class PurchaseWithTransportCosts : Purchase
    {
        /// <summary>
        /// Transporе costs value 
        /// </summary>
        private readonly Decimal _transportCosts;
        /// <summary>
        /// Purchase with transport costs class constructor calling base constructor
        /// </summary>
        /// <param name="price">Purchase price value</param>
        /// <param name="date">Purchase date value</param>
        /// <param name="quantity">Purchase quantity value</param>
        /// <param name="transportCosts">Purchase transport costs value</param>
        public PurchaseWithTransportCosts(Decimal price, DateTime date, UInt32 quantity, Decimal transportCosts)
            : base(date, quantity)
        {
            _transportCosts = transportCosts;
            Price = PriceIs(price);
            Type = TypeOfPurchase.PurchaseWithTransportCost;
        }
        /// <summary>
        /// Overriding method from inherit abstract class
        /// </summary>
        /// <param name="price">Purchase price</param>
        /// <returns>Result purchase price</returns>
        protected override sealed Decimal PriceIs(Decimal price)
        {
            return price - _transportCosts;
        }
    }
}
