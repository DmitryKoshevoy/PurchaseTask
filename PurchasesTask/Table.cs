using System;
using System.Collections.Generic;

namespace PurchasesTask
{
    /// <summary>
    /// Static class that builds a table
    /// </summary>
    static class Table
    {
        /// <summary>
        /// Build row static method
        /// </summary>
        /// <param name="purchase">Purchase</param>
        /// <returns>String that represents row</returns>
        static private String Row(Purchase purchase)
        {
            Console.WriteLine(new string('-', 95));
            return "|" + AlignCentre(purchase.Type.ToString(), 28) + "|"
                   + AlignCentre(purchase.Date.ToShortDateString(), 16) + "|"
                   + AlignCentre(purchase.Price.ToString(), 13) + "|"
                   + AlignCentre(purchase.Quantity.ToString(), 10) + "|"
                   + AlignCentre(purchase.BoughtInPurchaseDate.ToString(), 22) + "|";
        }
       /// <summary>
       /// Build table head static method
       /// </summary>
       /// <returns>String that represents table head</returns>
       static private String Head()
        {
            Console.SetWindowSize(100, 40);
            Console.WriteLine(new string('-', 95));
            return "|" + AlignCentre("Type of Purchase", 28) + "|"
                   + AlignCentre("Date of purchase", 16) + "|"
                   + AlignCentre("Price, rub.", 13) + "|"
                   + AlignCentre("Quantity", 10) + "|"
                   + AlignCentre("Wether get in 10 day", 22) + "|";
        }
        /// <summary>
        /// Build tabe tail static method
        /// </summary>
       /// <returns>String that represents table tail</returns>
        static private String Tail()
        {
            return new string('-', 95) + "\n";
        }
        /// <summary>
        /// Align centre method 
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="width">Colonum width</param>
        /// <returns></returns>
        static private string AlignCentre(string text, int width)
        {
            return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
        /// <summary>
        /// Build output table method
        /// </summary>
        /// <param name="list">Purchase list</param>
        static public void OutputTable(List<Purchase> list)
        {
            Console.WriteLine(Head());
            foreach (var purchase in list)
            {
                Console.WriteLine(Row(purchase));
            }
            Console.WriteLine(Tail());
        }

    }
}
