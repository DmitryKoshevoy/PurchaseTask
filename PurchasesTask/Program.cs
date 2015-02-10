using System;
using System.Collections.Generic;

namespace PurchasesTask
{
    class Program
    {
        private static void OutputTable(IEnumerable<Purchase> list)
        {
            Console.WriteLine(Purchase.Head());
            foreach (var purchase in list)
            {
                Console.WriteLine(purchase.ToString());
            }
            Console.WriteLine(Purchase.Tail());
        }
        static void Main(string[] args)
        {
            var myPurchaseList = new List<Purchase>();
            var myDates = new DateTime[10];
            for(var i =0; i<myDates.Length; i++)
            {
                myDates[i] = new DateTime(2015,02,i*2+4);
            }
            for (var i = 0; i < 3; i++)
            {
                myPurchaseList.Add(new PurchaceCasual(580000+i*15450, myDates[i*4], 2));
                myPurchaseList.Add(new PurchaseWithDiscount(3590000+i*5000, myDates[i], 1, Convert.ToByte(32+i)));
                myPurchaseList.Add(new PurchaseWithTransportCosts(240000, myDates[i*2+1], 3, 55500-i*8000));
                myPurchaseList.Add(new PurchaseWithBonus(6805600+i*32450, myDates[i+1], 2, 445350));
            }
            myPurchaseList.Sort();
            OutputTable(myPurchaseList);
            Console.WriteLine("Table sorted by purchase type");
            myPurchaseList.Sort((purchase, purchase1) => purchase.Type.CompareTo(purchase1.Type));
            OutputTable(myPurchaseList);
            Console.ReadKey();
        }
    }
}
