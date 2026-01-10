using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStoreSystem.Model.ViewModel
{
    public class CartItemVM
    {
        public int SkuId { get; set; }
        public string SKUCode { get; set; } = "";
        public string ProductName { get; set; } = "";

        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }

        public decimal LineTotal => Qty * UnitPrice;
    }
}
