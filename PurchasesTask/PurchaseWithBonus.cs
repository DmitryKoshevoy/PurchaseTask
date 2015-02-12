using System;

namespace PurchasesTask
{
    /// <summary>
    /// Purchase with bonus product class inherits abstract purchase class
    /// </summary>
    class PurchaseWithBonus : Purchase
    {
        /// <summary>
        /// Bonus product price value
        /// </summary>
        private readonly Decimal _bonusProdPrice;
        /// <summary>
        /// Purchase with bonus class constructor calling base constructor
        /// </summary>
        /// <param name="price">Purchase price value</param>
        /// <param name="date">Purchase date value</param>
        /// <param name="quantity">Purchase quantity value</param>
        /// <param name="bonusProdPrice">Bonus product price</param>
        public PurchaseWithBonus(Decimal price, DateTime date, UInt32 quantity, Decimal bonusProdPrice)
            : base(date, quantity)
        {
            _bonusProdPrice = bonusProdPrice;
            Price = PriceIs(price);// нужно перенести в базовый класс
            Type = TypeOfPurchase.PurchaseWithBonus;
        }
        /// <summary>
        /// Overriding method from inherit abstract class
        /// </summary>
        /// <param name="price">Purchase price</param>
        /// <returns>Result purchase price</returns>
        protected override sealed Decimal PriceIs(Decimal price)
        {
            return price - _bonusProdPrice;
        }
    }
}
