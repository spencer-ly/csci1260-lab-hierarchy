using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class StockItem
    {
        private string sku;
        private string name;
        private decimal unitPrice;
        private int quantityOnHand;
        private List<StockMovement> history;
        private int nextSeq;

        public string Sku 
        {
            get
            {
                return sku;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public decimal UnitPrice 
        {
            get
            {
                return unitPrice;
            }
        }
        public int QuantityOnHand
        {
            get
            {
                return quantityOnHand;
            }
        }
        public int MoveCount
        {
            get
            {
                return history.Count;
            }
        }

        protected StockItem(string sku, string name, decimal unitPrice, int quantityOnHand)
        {

            this.sku = sku;
            this.name = name;

            if (unitPrice < 0)
            {
                this.unitPrice = 0;
            }
            else
            {
                this.unitPrice = unitPrice;
            }

            if (quantityOnHand < 0)
            {
                this.quantityOnHand = 0;
            }
            else
            {
                this.quantityOnHand = quantityOnHand;
            }

            history = new List<StockMovement>();
            nextSeq = 1;

        }

        public abstract string Category();

        public abstract decimal HandlingFee();
        

        public decimal ExtendedValue()
        {
            return (UnitPrice + HandlingFee()) * QuantityOnHand;
        }

        public bool Receive(int count)
        {
            if (count <= 0)
            { 
                return false; 
            }
            else 
            { 
                quantityOnHand += count;
                history = new List<StockMovement>();
                nextSeq++;
                return true;
            }

        }





    }
}
