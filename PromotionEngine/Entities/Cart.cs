using System;
using PromotionEngine.Entities;
using PromotionEngine.Interfaces;

/// <summary>
/// This class is place holder representing Cart with Unique Product SKUs
/// </summary>
public class Cart :ICart
{
	 
	public Cart()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	public decimal Total { get; set; }

	public void AddProduct(Product item , int qty)
	{
		//adding product to cart sits here
	}

	public void Checkout()
	{
		// Handle Checkout responsibilty
	}


}
