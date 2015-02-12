using System;

namespace PurchasesTask
{
    /// <summary>
    /// Purchase casual class inherits abstract purchase class
    /// </summary>
    class PurchaceCasual : Purchase
    {
        /// <summary>
        /// Purchase casual class constructor calling base constructor
        /// </summary>
        /// <param name="price">Purchase price value</param>
        /// <param name="date">Purchase date value</param>
        /// <param name="quantity">Purchase quantity value</param>
        public PurchaceCasual(Decimal price, DateTime date, UInt32 quantity):base(date,quantity)
        {
            Price = PriceIs(price);
            Type = TypeOfPurchase.CasualPurchase;
        }
        /// <summary>
        /// Overriding method from inherit abstract class
        /// </summary>
        /// <param name="price">Purchase price</param>
        /// <returns>Result purchase price</returns>
        protected override sealed Decimal PriceIs(Decimal price)
        {
            return price;
        }
    }
}
