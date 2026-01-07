using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class Unit
{
    public int UnitId { get; set; }

    public string UnitName { get; set; } = null!;

    public virtual ICollection<ProductSku> ProductSkus { get; set; } = new List<ProductSku>();
}
