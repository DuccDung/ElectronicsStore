using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class Product
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public int? BrandId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public int WarrantyMonths { get; set; }

    public bool IsSerialized { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<ProductSku> ProductSkus { get; set; } = new List<ProductSku>();
}
