using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Shop : IReportable
    {
        private string name;
        private List<StockItem> items;


        public string Name 
        {
            get
            {
                return name;
            }
        }
        public int Count
        {
            get 
            { 
                return items.Count; 
            }
        }


        //public string Shop(string name) 
        //{
        //    this.name = name;

        //    items = new List<StockItem>();

        //}

        //public bool Add(StockItem item)
        //{

        //}

        //public StockItem Find(string sku)
        //{
        //    return sku;
        //}

        //left off here^^^^^^^^^^^
    }
}
