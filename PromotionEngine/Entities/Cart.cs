using System;
using System.Collections.Generic;
using System.Linq;
using PromotionEngine.Entities;
using PromotionEngine.Interfaces;

/// <summary>
/// This class is place holder representing Cart with Unique Product SKUs
/// to address unique items we can take dictionary to hold the SKU
/// </summary>
public class Cart :ICart
{

	private Dictionary<string, CartItem> _cartItems = new Dictionary<string, CartItem>();
	private List<CartItem> lstCartItems = new List<CartItem>();



	public Cart()
	{
		Promotions = new List<Promotion>();
		Total = 0;
	}

	public List<Promotion> Promotions { get; set; }

	public decimal Total { get; set; }

	/// <summary>
	/// Property to access CartItems hiding abstraction of  Dictionary
	/// </summary>
	public List<CartItem> CartItems
	{
		get { return _cartItems.Values.ToList(); }

	}


	public void AddProduct(Product item , int qty)
	{
		//add product to dictionary
		if (!_cartItems.ContainsKey(item.SKU))
		{
			_cartItems.Add(item.SKU, new CartItem() { Item = item, OrderedQty = qty, ProcessedQty = 0, ToBeProcessedQty = qty });
		}
		else
			throw new Exception("Adding duplicate Item ");


	}
	/// <summary>
	/// Using Facade pattern delegate functionality to subsystems
	/// </summary>
	public void Checkout()
	{
		ApplyPromotions();
		CalculateGrossAmount();
		CalculateBillTotal();
		PrintCartItems();
	}
		
	/// <summary>
	/// Using Iterator pattern apply one or more promotions
	/// </summary>
	private void ApplyPromotions()
	{
		foreach (var promotion in Promotions)
		{
			promotion.ApplyRule(this);
		}
	}

	/// <summary>
	/// Additional methods to Override new Promotions
	/// </summary>
	/// <param name="lstPromotions"></param>
	public void AddPromotions(List<Promotion> lstPromotions)
	{
		Promotions = lstPromotions;
	}

	/// <summary>
	/// Subsystem to process each item for calculating Item Gross amount
	/// </summary>
	private void CalculateGrossAmount()
	{
		foreach (var item in CartItems.Where(p => p.ToBeProcessedQty > 0))
		{
			// sum up gross amount with applied rules
			item.GrossAmount += (item.ToBeProcessedQty * item.Item.UnitPrice);
			//update Processed Quantity
			item.ProcessedQty += item.ToBeProcessedQty;
			//update remaining quantity to apply if any other rule matches.
			item.ToBeProcessedQty -= item.ToBeProcessedQty;
		}
	}

	/// <summary>
	/// Total calculation of bill from multiple item and we can further add discount or any other feature at bill level
	/// </summary>
	private void CalculateBillTotal()
	{
		this.Total = this.CartItems.Sum(p => p.GrossAmount);
	}

	/// <summary>
	/// A method to track current state of objects for UI
	/// </summary>
	public void PrintCartItems()
	{

		foreach (var item in this.CartItems)
		{
			Console.WriteLine(string.Format(" Product: {0} , OrderedQty : {1} , GrossAmount :{2} ", item.Item.SKU, item.OrderedQty, item.GrossAmount));
		}

		Console.WriteLine(string.Format("Total:{0}", this.Total));
	}



}
