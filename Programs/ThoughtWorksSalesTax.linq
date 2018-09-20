<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public class ProductCategory
{
	public int ProductCategoryId { get; set; }
	
	public string ProductCategoryName { get; set; }
	
	public ProductCategory(int productCategoryId, string productCategoryName)
	{
		this.ProductCategoryId = productCategoryId;
		this.ProductCategoryName = productCategoryName;
	}
}

public class Tax
{
	public int TaxId { get; set; }
	
	public string TaxName { get; set; }
	
	public Tax(int taxId, string taxName)
	{
		this.TaxId = taxId;
		this.TaxName = taxName;
	}
}

public class Product
{
	public int ProductId { get; set; }
	
	public string ProductName { get; set; }
	
	public int ProductCategoryId { get; set; }
	
	public Product(int productId, string productName, int productCategoryId)
	{
		this.ProductId = productId;
		this.ProductName = productName;
		this.ProductCategoryId = productCategoryId;
	}
}

public class Item
{
	public int ItemId { get; set; }
	
	public int ProductId { get; set; }
	
	public int LotId { get; set; }
	
	public Item(int itemId, int productId, int lotId)
	{
		this.ItemId = itemId;
		this.ProductId = productId;
		this.LotId = lotId;
	}
}

public class Lot
{
	public int LotId { get; set; }
	
	public bool Imported { get; set; }
	
	public Lot(int lotId, bool imported)
	{
		this.LotId = lotId;
		this.Imported = imported;
	}
}
