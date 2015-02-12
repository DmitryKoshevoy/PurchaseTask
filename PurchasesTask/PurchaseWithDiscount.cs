using System;

namespace PurchasesTask
{
    /// <summary>
    /// Purchase with discount class inherits abstract purchase class
    /// </summary>
    class PurchaseWithDiscount : Purchase
    {
        /// <summary>
        /// Percent maximum value is 100
        /// </summary>
        private const Byte MaxPercentValue = 100;
        /// <summary>
        /// Minimum note value is 50 rubles
        /// </summary>
        private const Byte MinNoteValue = 50;
        /// <summary>
        /// Discount value
        /// </summary>
        private readonly Double _discountValue;
        /// <summary>
        /// Purchase with discount class constructor calling base constructor
        /// </summary>
        /// <param name="price">Purchase price value</param>
        /// <param name="date">Purchase date value</param>
        /// <param name="quantity">Purchase quantity value</param>
        /// <param name="discount">Purchase discount value</param>
        public PurchaseWithDiscount(Decimal price, DateTime date, UInt32 quantity, Double discount)
            : base(date,quantity)
        {
            _discountValue = discount;
            Price = PriceIs(price);
            Type = TypeOfPurchase.PurchaseWithDiscount;
        }
        /// <summary>
        /// Overriding method from inherit abstract class
        /// </summary>
        /// <param name="price">Purchase price</param>
        /// <returns>Result purchase price</returns>
        protected override sealed Decimal PriceIs(Decimal price)
        {
            var value = Decimal.Round(Convert.ToDecimal(price*(1 - (Decimal)_discountValue/MaxPercentValue)));
            return value%MinNoteValue == 0 ? value : value - value%MinNoteValue;
        }
    }
}
