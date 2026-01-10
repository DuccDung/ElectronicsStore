using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStoreSystem.Model.ViewModel
{
    public class ProductListItemVM
    {
        public int ProductID { get; set; }
        public int SkuID { get; set; }

        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }

        public string SKUCode { get; set; }
        public string Model { get; set; }

        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}

