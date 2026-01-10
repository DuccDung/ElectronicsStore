using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStoreSystem.Model.ViewModel
{
    public class Products
    {
        public int SkuID { get; set; }
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
    }
    public class ProductSelected
    {
        public int SkuID { get; set; }
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}
