using System;

namespace PurchasesTask
{
    /// <summary>
    /// Named constants that represents type of purchases
    /// </summary>
    public enum TypeOfPurchase
    {
        CasualPurchase,
        PurchaseWithDiscount,
        PurchaseWithTransportCost,
        PurchaseWithBonus
    };
    /// <summary>
    /// Abstract purchase class
    /// </summary>
     public abstract class Purchase : IComparable<Purchase>
    {
        /// <summary>
        /// Nessesary purchase date
        /// </summary>
        private const Int32 PurchaseDate = 10;
        /// <summary>
        /// Purchase type property
        /// </summary>
        public TypeOfPurchase Type { get; protected set; }
         /// <summary>
         /// Purchase price property
         /// </summary>
        public Decimal Price { get; protected set; }
         /// <summary>
         /// Purchase date property
         /// </summary>
        public DateTime Date { get; private set; }
         /// <summary>
         /// Quantity of purchases property
         /// </summary>
        public UInt32 Quantity { get; private set; }
         /// <summary>
         /// Wether bought in purchase day property
         /// </summary>
        public Boolean BoughtInPurchaseDate { get { return Date.Day == PurchaseDate; } }
         /// <summary>
         /// Abstract purchase class constructor
         /// </summary>
         /// <param name="date">Date of purchase</param>
         /// <param name="quantity">Quantity of purchase</param>
        protected Purchase(DateTime date, UInt32 quantity)
        {
            Quantity = quantity;
            Date = date;
        }
         /// <summary>
         /// Abstract method of price calculation
         /// </summary>
         /// <param name="price">Price of purchase</param>
         /// <returns>Result purchase price</returns>
        protected abstract Decimal PriceIs(Decimal price);//из название не понятно, что делает метод
         /// <summary>
         /// Explicit interface member implementation
         /// </summary>
         /// <param name="comparePart">Purchase</param>
         /// <returns>Position in the sort order</returns>
        public int CompareTo(Purchase comparePart)
        {
            return Date.Day.CompareTo(comparePart.Date.Day);
        }
    }
}
