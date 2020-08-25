using System;
using PromotionEngine.Interfaces;

/// <summary>
/// This class to represent Abstract Factory for Promotion rules which need to provide own logic based on rule
/// </summary>
public abstract class Promotion 
{
	 public int RuleID { get; set; }

	public string RuleName { get; set; }

	public string Description { get; set; }

	public bool IsActive { get; set; }

	public abstract void ApplyRule(Cart cart);
}
