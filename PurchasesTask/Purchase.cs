using System;

namespace PurchasesTask
{
    public enum TypeOfPurchase
    {
        CasualPurchase,
        PurchaseWithDiscount,
        PurchaseWithTransportCost,
        PurchaseWithBonus
    };
    abstract class Purchase : IComparable<Purchase>
    {

        public TypeOfPurchase Type { get; protected set; }
        public Decimal Price { get; protected set; }
        public DateTime Date { get; private set; }
        public UInt32 Quantity { get; private set; }
        public Boolean TenDayBought { get; private set; }

        protected Purchase(DateTime date, UInt32 quantity)
        {
            TenDayBought = IsBoughtATenDay(date);
            Quantity = quantity;
            Date = date;
        }

        protected abstract Decimal PriceIs(Decimal price);

        private static Boolean IsBoughtATenDay(DateTime date)
        {
            return date.Day == 10;
        }

        public int CompareTo(Purchase comparePart)
        {
            return Date.Day.CompareTo(comparePart.Date.Day);
        }

        public override string ToString()
        {
            Console.WriteLine(new string('-', 95));
            return "|" + AlignCentre(Type.ToString(), 28) + "|"
                   + AlignCentre(Date.ToShortDateString(), 16) + "|"
                   + AlignCentre(Price.ToString(), 13) + "|"
                   + AlignCentre(Quantity.ToString(), 10) + "|"
                   + AlignCentre(TenDayBought.ToString(), 22) + "|";
        }

        static public String Head()
        {
            Console.SetWindowSize(100,40);
            Console.WriteLine(new string('-', 95));
            return "|" + AlignCentre("Type of Purchase", 28) + "|"
                   + AlignCentre("Date of purchase", 16) + "|"
                   + AlignCentre("Price, rub.", 13) + "|"
                   + AlignCentre("Quantity", 10) + "|"
                   + AlignCentre("Wether get in 10 day", 22) + "|";
        }

        static public String Tail()
        {
            return new string('-', 95)+"\n";
        }
        static private string AlignCentre(string text, int width)
        {
            return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
    }
}
