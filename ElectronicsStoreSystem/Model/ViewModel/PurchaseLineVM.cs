using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStoreSystem.Model.ViewModel
{
    public class PurchaseLineVM
    {
        public int SkuId { get; set; }
        public string ProductName { get; set; } = "";
        public decimal Qty { get; set; }
        public decimal UnitCost { get; set; }
        public decimal LineTotal => Qty * UnitCost;
    }
}
