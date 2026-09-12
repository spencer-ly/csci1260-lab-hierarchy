using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PerishableGood
    {
        private int shelfLifeDays;

        public const decimal SurchargeFee = 0.40m;
        public int ShelfLifeDays
        {
            get
            {
                return shelfLifeDays;
            }
        }
        public bool IsOnSale { get; }

        public PerishableGood(string sku, string name, decimal unitPrice, int quantityOnHand, double weightPounds, int shelfLifeDays)
        {

        }

        public override string Category()
        {

        }

    }
}
