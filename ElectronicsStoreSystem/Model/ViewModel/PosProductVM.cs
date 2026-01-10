using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStoreSystem.Model.ViewModel
{
    public class PosProductVM
    {
        public int SkuId { get; set; }
        public int ProductId { get; set; }

        public string SKUCode { get; set; } = "";
        public string ProductName { get; set; } = "";
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = "";
        public int BrandId { get; set; }
        public string BrandName { get; set; } = "";

        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }

        public decimal AvailableQty { get; set; }
    }
}

