using System;
using System.Collections.Generic;

namespace PurchasesTask
{
    class Program
    {
        /// <summary>
        /// Creating purchases dates and purchases list.
        /// Than sorting list by purchase day and displaying table.
        /// Make another one sort by purchase type ans displauing new table.
        /// </summary>
        static void Main()
        {
            var myDates = new[]
            {
                new DateTime(2015, 02, 10),
                new DateTime(2015, 02, 3),
                new DateTime(2015, 02, 17),
                new DateTime(2015, 02, 27),
                new DateTime(2015, 02, 10),
                new DateTime(2015, 02, 1),
                new DateTime(2015, 02, 25),
                new DateTime(2015, 02, 13),
                new DateTime(2015, 02, 24),
                new DateTime(2015, 02, 10)
            };
            var myPurchaseList = new List<Purchase>
            {
                new PurchaceCasual(945650, myDates[1], 2),
                new PurchaseWithDiscount(7656800, myDates[0], 1, 17.65),
                new PurchaseWithTransportCosts(1345000, myDates[2], 5, 560000),
                new PurchaseWithBonus(2250000, myDates[3], 4, 345000),
                new PurchaceCasual(153600, myDates[4], 6),
                new PurchaseWithDiscount(480000, myDates[5], 2, 33),
                new PurchaseWithTransportCosts(5670000, myDates[6], 1, 560000),
                new PurchaseWithBonus(450000, myDates[7], 13, 85000),
                new PurchaseWithDiscount(830500, myDates[8], 9, 54),
                new PurchaseWithDiscount(342800, myDates[9], 2, 11.5),
                new PurchaceCasual(13500, myDates[0], 24),
                new PurchaceCasual(670500, myDates[2], 1),
            };
            myPurchaseList.Sort();
            Table.OutputTable(myPurchaseList);
            Console.WriteLine("Table sorted by purchase type");
            myPurchaseList.Sort((purchase, purchase1) => purchase.Type.CompareTo(purchase1.Type));
            Table.OutputTable(myPurchaseList);
            Console.ReadKey();
        }
    }
}
